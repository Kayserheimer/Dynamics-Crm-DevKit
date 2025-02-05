﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using DynamicsCrm.DevKit.Shared.Models;
using System.Collections.Specialized;
using System;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk.Metadata.Query;

namespace DynamicsCrm.DevKit.Shared.Helper
{
    public class XrmHelper
    {
        public static List<string> GetAllCustomActions(CrmServiceClient service)
        {
            var fetchData = new
            {
                customizationlevel = "1",
                primaryobjecttypecode = "none",
                endpoint = "api/data"
            };
            var fetchXml = $@"
<fetch>
  <entity name='sdkmessagerequest'>
    <attribute name='name' />
    <attribute name='primaryobjecttypecode' />
    <filter type='and'>
      <condition attribute='customizationlevel' operator='eq' value='{fetchData.customizationlevel}'/>
    </filter>
    <link-entity name='sdkmessagepair' from='sdkmessagepairid' to='sdkmessagepairid' link-type='inner'>
      <filter type='and'>
        <condition attribute='endpoint' operator='eq' value='{fetchData.endpoint}'/>
      </filter>
    </link-entity>
  </entity>
</fetch>";
            var rows = service.RetrieveMultiple(new FetchExpression(fetchXml));
            var list2 = new List<Entity>();
            foreach (var entity in rows.Entities)
            {
                var primaryobjecttypecode = entity.GetAttributeValue<string>("primaryobjecttypecode");
                if (primaryobjecttypecode == null || primaryobjecttypecode == "none")
                    list2.Add(entity);
            }
            var list = new List<XrmEntity>();
            foreach (var entity in list2)
            {
                list.Add(new XrmEntity {
                    LogicalName = entity.GetAttributeValue<string>("name"),
                    Name = GetSchemaName(service, entity.GetAttributeValue<string>("primaryobjecttypecode"))
                });
            }
            var json = SimpleJson.SerializeObject(list);
            return list
                .Where(x => x.Name.ToLower() == "none")
                .Select(x => x.LogicalName)
                .ToList();
        }

        public static List<string> GetAllCustomApis(CrmServiceClient service, string entity)
        {
            var conditionEntity = string.Empty;
            if (entity != "none")
                conditionEntity = $"<condition attribute='boundentitylogicalname' operator='eq' value='{entity}'/>";
            else
                conditionEntity = $"<condition attribute='boundentitylogicalname' operator='null' />";
            var fetchData = new
            {
                statecode = "0"
            };
            var fetchXml = $@"
<fetch>
  <entity name='customapi'>
    <attribute name='name' />
    <attribute name='sdkmessageid' />
    <attribute name='boundentitylogicalname' />
    <filter>
      <condition attribute='statecode' operator='eq' value='{fetchData.statecode}'/>
      {conditionEntity}
    </filter>
  </entity>
</fetch>";
            var rows = service.RetrieveMultiple(new FetchExpression(fetchXml));
            return rows.Entities.Select(x => x.GetAttributeValue<EntityReference>("sdkmessageid")?.Name).ToList();
        }

        private static string GetSchemaName(CrmServiceClient service, string logicalName)
        {
            if (logicalName == null || logicalName == "none") return "None";
            var request = new RetrieveEntityRequest
            {
                EntityFilters = EntityFilters.Entity,
                LogicalName = logicalName
            };
            var response = (RetrieveEntityResponse)service.Execute(request);
            return response.EntityMetadata.SchemaName;
        }

        public static List<XrmEntity> GetAllEntities(CrmServiceClient service)
        {
            var request = new RetrieveAllEntitiesRequest
            {
                EntityFilters = EntityFilters.Entity,
                RetrieveAsIfPublished = true
            };
            var response = (RetrieveAllEntitiesResponse)service.Execute(request);
            var entities = new List<XrmEntity>();
            foreach (var entity in response.EntityMetadata)
                entities.Add(new XrmEntity
                {
                    Name = entity.SchemaName,
                    LogicalName = entity.LogicalName,
                    HasImage = !string.IsNullOrEmpty(entity.PrimaryImageAttribute),
                    EntityTypeCode = entity.ObjectTypeCode ?? -1,
                    IsCustomEntity = entity.IsCustomEntity ?? false
                });
            entities = entities.OrderBy(entity => entity.Name).ToList();
            return entities;
        }

        public static List<int> GetProvisionedLanguages(CrmServiceClient service)
        {
            var request = new RetrieveProvisionedLanguagesRequest();
            var response = (RetrieveProvisionedLanguagesResponse)service.Execute(request);
            return response.RetrieveProvisionedLanguages.ToList();
        }


        public static decimal? GetMetadataMinValue(AttributeMetadata attribute)
        {
            if (attribute is IntegerAttributeMetadata attr1)
                return attr1.MinValue ?? -1;
            if (attribute is DecimalAttributeMetadata attr2)
                return attr2.MinValue ?? -1;
            if (attribute is MoneyAttributeMetadata attr3)
                return attr3.MinValue != null ? (decimal)attr3.MinValue.Value : -1;
            if (attribute is DoubleAttributeMetadata attr)
                return attr.MinValue != null ? (decimal)attr.MinValue.Value : -1;
            return (decimal?)null;
        }

        public static decimal? GetMetadataMaxValue(AttributeMetadata attribute)
        {
            if (attribute is IntegerAttributeMetadata attr1)
                return attr1.MaxValue ?? -1;
            if (attribute is DecimalAttributeMetadata attr2)
                return attr2.MaxValue ?? -1;
            if (attribute is MoneyAttributeMetadata attr3)
                return attr3.MaxValue != null ? (decimal)attr3.MaxValue.Value : -1;
            if (attribute is DoubleAttributeMetadata attr)
                return attr.MaxValue != null ? (decimal)attr.MaxValue.Value : -1;
            return (decimal?)null;
        }

        public static int? GetMetadataMaxLengthValue(AttributeMetadata attribute)
        {
            if (attribute is StringAttributeMetadata attr1)
                return attr1.MaxLength ?? (int?)null;
            if (attribute is MemoAttributeMetadata attr2)
                return attr2.MaxLength ?? (int?)null;
            return (int?)null;
        }

        public static NameValueCollection GetMetadataOptionSetValues(AttributeMetadata attribute)
        {
            if (attribute is PicklistAttributeMetadata optionMetadata1)
            {
                var values = new NameValueCollection();
                foreach (var c in optionMetadata1.OptionSet.Options)
                    values.Add(Utility.SafeName(c.Label.UserLocalizedLabel.Label), c.Value?.ToString());
                return values;
            }
            else if (attribute is StateAttributeMetadata optionMetadata2)
            {
                var values = new NameValueCollection();
                foreach (var c in optionMetadata2.OptionSet.Options)
                    values.Add(Utility.SafeName(c.Label.UserLocalizedLabel.Label), c.Value?.ToString());
                return values;
            }
            else if (attribute is StatusAttributeMetadata optionMetadata)
            {
                var values = new NameValueCollection();
                foreach (var c in optionMetadata.OptionSet.Options)
                    values.Add(Utility.SafeName(c.Label.UserLocalizedLabel.Label), c.Value?.ToString());
                return values;
            }
            else if (attribute is MultiSelectPicklistAttributeMetadata optionMetadata3)
            {
                var values = new NameValueCollection();
                foreach (var c in optionMetadata3.OptionSet.Options)
                    values.Add(Utility.SafeName(c.Label.UserLocalizedLabel.Label), c.Value?.ToString());
                return values;
            }
            return new NameValueCollection();
        }

        public static List<string> GetSdkMessages(CrmServiceClient service, string logicalName)
        {
            var request = new RetrieveEntityRequest
            {
                EntityFilters = EntityFilters.Entity,
                LogicalName = logicalName
            };
            var response = (RetrieveEntityResponse)service.Execute(request);
            var fetchData = new
            {
                primaryobjecttypecode = response.EntityMetadata.ObjectTypeCode,
                iscustomprocessingstepallowed = "1"
            };
            var fetchXml = $@"
<fetch>
  <entity name='sdkmessage'>
    <attribute name='name' />
    <link-entity name='sdkmessagefilter' from='sdkmessageid' to='sdkmessageid'>
      <filter type='and'>
        <condition attribute='primaryobjecttypecode' operator='eq' value='{fetchData.primaryobjecttypecode}'/>
        <condition attribute='iscustomprocessingstepallowed' operator='eq' value='{fetchData.iscustomprocessingstepallowed}'/>
      </filter>
    </link-entity>
  </entity>
</fetch>";
            var rows = service.RetrieveMultiple(new FetchExpression(fetchXml));
            var messages = (from entity in rows.Entities
                            select entity["name"].ToString()
                ).ToList();
            messages.Sort();
            return messages;
        }

        public static string GeneratedLateBoundClass(CrmServiceClient service, string crmName, string entitySchemaName, string nameSpace, string sharedNameSpace)
        {
            var lateBound = new CSharpLateBound();
            return lateBound.Go(service, Utility.ConvertCrmNameToCrmVersionName(crmName), entitySchemaName, nameSpace, sharedNameSpace);
        }

        public static List<PluginInputOutputParameter> GetPluginInputOutputParameters(CrmServiceClient service, string entityName, string requestName)
        {
            var fetchData = new
            {
                name = requestName,
                name2 = $"{requestName + entityName}",
                endpoint = "api/data"
            };
            var fetchXml = $@"
<fetch>
  <entity name='sdkmessagerequest'>
    <filter type='or'>
      <condition attribute='name' operator='eq' value='{fetchData.name}'/>
      <condition attribute='name' operator='eq' value='{fetchData.name2}'/>
    </filter>
    <link-entity name='sdkmessagepair' from='sdkmessagepairid' to='sdkmessagepairid'>
      <filter type='and'>
        <condition attribute='endpoint' operator='eq' value='{fetchData.endpoint}'/>
      </filter>
    </link-entity>
    <link-entity name='sdkmessagerequestfield' from='sdkmessagerequestid' to='sdkmessagerequestid' link-type='inner' alias='f'>
      <attribute name='name' />
      <attribute name='clrparser' />
      <attribute name='optional' />
      <attribute name='position' />
    </link-entity>
  </entity>
</fetch>";
            var rows = service.RetrieveMultiple(new FetchExpression(fetchXml));
            var list = new List<PluginInputOutputParameter>();
            var sdkMessageRequestId = Guid.Empty;
            foreach (var row in rows.Entities)
            {
                var name = (string)row.GetAttributeValue<AliasedValue>("f.name")?.Value ?? string.Empty;
                var clrparser = (string)row.GetAttributeValue<AliasedValue>("f.clrparser")?.Value ?? string.Empty;
                var optional = (bool?)row.GetAttributeValue<AliasedValue>("f.optional")?.Value ?? false;
                var position = (int?)row.GetAttributeValue<AliasedValue>("f.position")?.Value ?? -1;
                list.Add(new PluginInputOutputParameter
                {
                    Name = name,
                    Position = position,
                    Require = optional,
                    Type = clrparser.Split(",".ToCharArray())[0],
                    ParameterType = ParameterType.Input
                });
                sdkMessageRequestId = row.Id;
            }

            var fetchData2 = new
            {
                sdkmessagerequestid = sdkMessageRequestId
            };
            var fetchXml2 = $@"
<fetch>
  <entity name='sdkmessageresponse'>
    <filter type='and'>
      <condition attribute='sdkmessagerequestid' operator='eq' value='{fetchData2.sdkmessagerequestid}'/>
    </filter>
    <link-entity name='sdkmessageresponsefield' from='sdkmessageresponseid' to='sdkmessageresponseid' link-type='inner' alias='f'>
      <attribute name='name' />
      <attribute name='clrformatter' />
      <attribute name='position' />
    </link-entity>
  </entity>
</fetch>";
            var rows2 = service.RetrieveMultiple(new FetchExpression(fetchXml2));
            foreach (var row in rows2.Entities)
            {
                var name = (string)row.GetAttributeValue<AliasedValue>("f.name")?.Value ?? string.Empty;
                var clrformatter = (string)row.GetAttributeValue<AliasedValue>("f.clrformatter")?.Value ??
                                   string.Empty;
                var optional = false;
                var position = (int?)row.GetAttributeValue<AliasedValue>("f.position")?.Value ?? -1;
                list.Add(new PluginInputOutputParameter
                {
                    Name = name,
                    Position = position,
                    Require = optional,
                    Type = clrformatter.Split(",".ToCharArray())[0],
                    ParameterType = ParameterType.Output
                });
            }
            list = list
                .OrderBy(order => order.ParameterType)
                .ThenBy(order => order.Position)
                .ToList();
            return list;
        }


        public static int GetObjectTypeCode(CrmServiceClient service, string logicalName)
        {
            var request = new RetrieveEntityRequest
            {
                EntityFilters = EntityFilters.Entity,
                LogicalName = logicalName
            };
            var response = (RetrieveEntityResponse)service.Execute(request);
            if (response.EntityMetadata.ObjectTypeCode != null)
                return response.EntityMetadata.ObjectTypeCode.Value;
            return -1;
        }

        public static List<string> GetForms(CrmServiceClient service, string logicalName)
        {
            var fetchData = new
            {
                formactivationstate = "1",
                objecttypecode = GetObjectTypeCode(service, logicalName),
                type = "2",
                type2 = "7"
            };
            var fetchXml = $@"
<fetch>
  <entity name='systemform'>
    <attribute name='description' />
    <attribute name='name' />
    <attribute name='formxml' />
    <attribute name='type' />
    <order attribute='name' descending='false'/>
    <filter type='and'>
      <condition attribute='formactivationstate' operator='eq' value='{fetchData.formactivationstate}'/>
      <condition attribute='objecttypecode' operator='eq' value='{fetchData.objecttypecode}'/>
      <filter type='or'>
        <condition attribute='type' operator='eq' value='{fetchData.type}'/>
        <condition attribute='type' operator='eq' value='{fetchData.type2}'/>
      </filter>
    </filter>
  </entity>
</fetch>";
            var rows = service.RetrieveMultiple(new FetchExpression(fetchXml));
            var forms = new List<string>();
            foreach (var entity in rows.Entities)
            {
                var name = entity.GetAttributeValue<string>("name");
                forms.Add(name);
            }
            return forms;
        }

        public static string BuildConnectionString(CrmConnection crmConnection)
        {
            if (crmConnection == null) return string.Empty;
            return BuildConnectionString(crmConnection.Type, crmConnection.Url, crmConnection.UserName, crmConnection.Password);
        }

        public static string BuildConnectionString(string type, string url, string user, string pass)
        {
            if (type == "ClientSecret")
                return $"AuthType=ClientSecret;Url={url};ClientId={user};ClientSecret={pass};";
            else if (type == "AD")
            {
                var arr = user.Split("\\".ToCharArray());
                if (arr.Length != 2)
                    throw new Exception("Please enter User name like: contoso\\jsmith");
                var domain = arr[0];
                user = arr[1];
                return $"AuthType={type};Url={url};Domain={domain};Username={user};Password={pass};";
            }
            return $"AuthType=OAuth;Url={url};Username={user};Password={pass};AppId=51f81489-12ee-4a9e-aaae-a2591f45987d;RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;LoginPrompt=Auto";
        }

        //public static string BuildConnectionString(string connectionString)
        //{
        //    if (connectionString.IndexOf("=ClientSecret;") >= 0) return connectionString;
        //    var array = connectionString.Split(";".ToCharArray());
        //    if (array.Length == 5)
        //    {
        //        var authType = array.First(x => x.ToLower().StartsWith("authtype=")).Split("=".ToCharArray())[1];
        //        var url = array.First(x => x.ToLower().StartsWith("url=")).Split("=".ToCharArray())[1];
        //        var userName = array.First(x => x.ToLower().StartsWith("username=")).Split("=".ToCharArray())[1];
        //        var password = array.First(x => x.ToLower().StartsWith("password="));
        //        if (password.EndsWith("=="))
        //            password = password.Split("=".ToCharArray())[1] + "==";
        //        else if (password.EndsWith("="))
        //            password = password.Split("=".ToCharArray())[1] + "=";
        //        else
        //            password = password.Split("=".ToCharArray())[1];
        //        password = EncryptDecrypt.DecryptString(password);
        //        return BuildConnectionString(authType, url, userName, password);
        //    }
        //    else if (array.Length == 6)
        //    {
        //        var authType = array.First(x => x.ToLower().StartsWith("authtype=")).Split("=".ToCharArray())[1];
        //        var url = array.First(x => x.ToLower().StartsWith("url=")).Split("=".ToCharArray())[1];
        //        var domain = array.First(x => x.ToLower().StartsWith("domain=")).Split("=".ToCharArray())[1];
        //        var userName = array.First(x => x.ToLower().StartsWith("username=")).Split("=".ToCharArray())[1];
        //        var password = array.First(x => x.ToLower().StartsWith("password="));
        //        if (password.EndsWith("=="))
        //            password = password.Split("=".ToCharArray())[1] + "==";
        //        else if (password.EndsWith("="))
        //            password = password.Split("=".ToCharArray())[1] + "=";
        //        else
        //            password = password.Split("=".ToCharArray())[1];
        //        password = EncryptDecrypt.DecryptString(password);
        //        return BuildConnectionString(authType, url, $"{domain}\\{userName}", password);
        //    }
        //    throw new Exception("Fail when BuildConnectionString");
        //}

        public static string BuildConnectionString(string connectionString)
        {
            if (!connectionString.ToLower().Contains("Password=".ToLower())) return connectionString;
            var value = string.Empty;
            var arr = connectionString.Split(";".ToCharArray());
            foreach (var item in arr)
            {
                if (item.ToLower().Contains("Password=".ToLower()))
                {
                    var password = string.Empty;
                    if (item.EndsWith("=="))
                        password = item.Split("=".ToCharArray())[1] + "==";
                    else if (item.EndsWith("="))
                        password = item.Split("=".ToCharArray())[1] + "=";
                    else
                        password = item.Split("=".ToCharArray())[1];
                    password = EncryptDecrypt.DecryptString(password);
                    value += "Password=" + password + ";";
                }
                else
                    value += item + ";";
            }
            value = value.Replace(";;", ";");
            if (value.ToLower().Contains("AuthType=OAuth".ToLower()))
            {
                if (!value.ToLower().Contains("RedirectUri=".ToLower()))
                {
                    value += "AppId=51f81489-12ee-4a9e-aaae-a2591f45987d;RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;LoginPrompt=Auto;";
                }
            }
            return value;
        }

        //public static string BuildConnectionStringLog(string connectionString)
        //{
        //    if (connectionString.ToLower().IndexOf("=ClientSecret;".ToLower()) >= 0) return connectionString;
        //    var array = connectionString.Split(";".ToCharArray());
        //    if (array.Length == 5)
        //    {
        //        var authType = array.First(x => x.ToLower().StartsWith("authtype=")).Split("=".ToCharArray())[1];
        //        var url = array.First(x => x.ToLower().StartsWith("url=")).Split("=".ToCharArray())[1];
        //        var userName = array.First(x => x.ToLower().StartsWith("username=")).Split("=".ToCharArray())[1];
        //        var password = "********";
        //        return BuildConnectionString(authType, url, userName, password);
        //    }
        //    else if (array.Length == 6)
        //    {
        //        var authType = array.First(x => x.ToLower().StartsWith("authtype=")).Split("=".ToCharArray())[1];
        //        var url = array.First(x => x.ToLower().StartsWith("url=")).Split("=".ToCharArray())[1];
        //        var domain = array.First(x => x.ToLower().StartsWith("domain=")).Split("=".ToCharArray())[1];
        //        var userName = array.First(x => x.ToLower().StartsWith("username=")).Split("=".ToCharArray())[1];
        //        var password = "********";
        //        return BuildConnectionString(authType, url, $"{domain}\\{userName}", password);
        //    }
        //    throw new Exception("Fail when BuildConnectionString");
        //}

        public static string BuildConnectionStringLog2(string connectionString)
        {
            if (!connectionString.ToLower().Contains("Password=".ToLower())) return connectionString;
            var value = string.Empty;
            var arr = connectionString.Split(";".ToCharArray());
            foreach(var item in arr)
            {
                if (item.ToLower().Contains("Password=".ToLower()))
                    value += "Password=********;";
                else
                    value += item + ";";
            }
            return value.Replace(";;", ";");
        }

        public static bool IsExistDataSource(CrmServiceClient crmServiceClient, string logicalname)
        {
            var filterExpression = new MetadataFilterExpression();
            logicalname = logicalname.ToLower();
            filterExpression.Conditions.Add(new MetadataConditionExpression("DataProviderId", MetadataConditionOperator.Equals, Guid.Parse("B2112A7E-B26C-42F7-9B63-9A809A9D716F")));
            var propertiesExpression = new MetadataPropertiesExpression(new string[7]
            {
                "DataProviderId",
                "LogicalName",
                "SchemaName",
                "MetadataId",
                "DisplayName",
                "ExternalName",
                "DisplayCollectionName"
            });
            var entityQueryExpression = new EntityQueryExpression();
            entityQueryExpression.Criteria = new MetadataFilterExpression();
            entityQueryExpression.Criteria = filterExpression;
            entityQueryExpression.Properties = propertiesExpression;
            var request = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpression
            };
            var response = (RetrieveMetadataChangesResponse)crmServiceClient.Execute(request);
            foreach (EntityMetadata entityMetadata in response.EntityMetadata)
                if (entityMetadata.LogicalName == logicalname)
                    return true;
            return false;
        }

        public static bool IsExistSolution(CrmServiceClient crmServiceClient, string solutionuniquename, out Guid solutionId, out string prefix)
        {
            solutionId = Guid.Empty;
            prefix = string.Empty;
            var fetchData = new
            {
                uniquename = solutionuniquename
            };
            var fetchXml = $@"
<fetch>
  <entity name='solution'>
    <attribute name='solutionid' />
    <filter>
      <condition attribute='uniquename' operator='eq' value='{fetchData.uniquename}'/>
    </filter>
    <link-entity name='publisher' from='publisherid' to='publisherid' alias='p'>
      <attribute name='customizationprefix' />
    </link-entity>
  </entity>
</fetch>";

            var rows = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchXml));
            if (rows.Entities.Count != 1) return false;
            var entity = rows.Entities[0];
            solutionId = entity.Id;
            prefix = $"{ entity.GetAttributeValue<AliasedValue>("p.customizationprefix").Value}_";
            return true;
        }
        public static bool IsVirtualTableSupportCRUD(CrmServiceClient crmServiceClient)
        {
            return crmServiceClient.ConnectedOrgVersion >= new Version("9.1.0.18950");
        }

        public static string ConnectedUrl(CrmServiceClient crmServiceClient)
        {
            var url = new Uri(crmServiceClient?.CrmConnectOrgUriActual?.AbsoluteUri).GetLeftPart(UriPartial.Authority);
            url = url?.Replace(".api.", ".");
            return url;
        }

        public static List<NameValueGuidExtend> GetAllSolutions(CrmServiceClient crmServiceClient)
        {
            var fetchData = new
            {
                ismanaged = "0",
                uniquename = "Default",
                uniquename2 = "Active",
                uniquename3 = "Basic"
            };
            var fetchXml = $@"
<fetch>
  <entity name='solution'>
    <attribute name='solutionid' />
    <attribute name='uniquename' />
    <filter>
      <condition attribute='ismanaged' operator='eq' value='{fetchData.ismanaged/*0*/}'/>
      <condition attribute='uniquename' operator='neq' value='{fetchData.uniquename/*Default*/}'/>
      <condition attribute='uniquename' operator='neq' value='{fetchData.uniquename2/*Active*/}'/>
      <condition attribute='uniquename' operator='neq' value='{fetchData.uniquename3/*Basic*/}'/>
    </filter>
    <order attribute='uniquename' />
    <link-entity name='publisher' from='publisherid' to='publisherid' alias='p'>
      <attribute name='customizationprefix' />
      <filter>
        <condition attribute='customizationprefix' operator='not-null' />
      </filter>
    </link-entity>
  </entity>
</fetch>";
            var rows = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchXml));
            var list = new List<NameValueGuidExtend>();
            foreach(var entity in rows.Entities)
            {
                list.Add(new NameValueGuidExtend {
                    Name = entity.GetAttributeValue<string>("uniquename") ?? string.Empty,
                    Value = entity.Id,
                    SolutionPrefix = entity.GetAttributeValue<AliasedValue>("p.customizationprefix")?.Value.ToString() ?? string.Empty,
                    SolutionUniqueName = entity.GetAttributeValue<string>("uniquename") ?? string.Empty
                });
            }
            return list;
        }

        public static List<string> GetAllDataSource(CrmServiceClient crmServiceClient)
        {
            var list = new List<string>();
            var filterExpression = new MetadataFilterExpression();
            filterExpression.Conditions.Add(new MetadataConditionExpression("DataProviderId", MetadataConditionOperator.Equals, Guid.Parse("B2112A7E-B26C-42F7-9B63-9A809A9D716F")));
            var propertiesExpression = new MetadataPropertiesExpression(new string[7]
            {
                "DataProviderId",
                "LogicalName",
                "SchemaName",
                "MetadataId",
                "DisplayName",
                "ExternalName",
                "DisplayCollectionName"
            });
            var entityQueryExpression = new EntityQueryExpression
            {
                Criteria = new MetadataFilterExpression()
            };
            entityQueryExpression.Criteria = filterExpression;
            entityQueryExpression.Properties = propertiesExpression;
            var request = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpression
            };
            var response = (RetrieveMetadataChangesResponse)crmServiceClient.Execute(request);
            foreach (EntityMetadata entityMetadata in response.EntityMetadata)
                list.Add(entityMetadata.LogicalName);
            return list;
        }
    }
}
