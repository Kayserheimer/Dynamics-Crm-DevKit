﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_ocsentimentdailytopicOptionSets
{
	public enum statecode
	{
		/// <summary>
		/// Active = 0
		/// </summary>
		Active = 0,
		/// <summary>
		/// Inactive = 1
		/// </summary>
		Inactive = 1
	}

	public enum statuscode
	{
		/// <summary>
		/// Active = 1
		/// </summary>
		Active = 1,
		/// <summary>
		/// Inactive = 2
		/// </summary>
		Inactive = 2
	}
}

namespace Dev.DevKit.Shared.Entities
{
	public partial class msdyn_ocsentimentdailytopic : EntityBase
	{
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string msdyn_conversationcount = "msdyn_conversationcount";
			public const string msdyn_conversationexample = "msdyn_conversationexample";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_ocsentimentdailytopicId = "msdyn_ocsentimentdailytopicid";
			public const string msdyn_sentimentdriverintradayweightimpact = "msdyn_sentimentdriverintradayweightimpact";
			public const string msdyn_sentimentscore = "msdyn_sentimentscore";
			public const string msdyn_topiccountpercentage = "msdyn_topiccountpercentage";
			public const string msdyn_topicdate = "msdyn_topicdate";
			public const string msdyn_topicindex = "msdyn_topicindex";
			public const string msdyn_topicname = "msdyn_topicname";
			public const string msdyn_weeklyid = "msdyn_weeklyid";
			public const string msdyn_weeklytopicid = "msdyn_weeklytopicid";
			public const string msdyn_weeklytopicname = "msdyn_weeklytopicname";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "msdyn_ocsentimentdailytopic";

		public const int EntityTypeCode = 10595;

		[DebuggerNonUserCode()]
		public msdyn_ocsentimentdailytopic()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_ocsentimentdailytopic(Guid msdyn_ocsentimentdailytopicId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_ocsentimentdailytopicId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_ocsentimentdailytopic(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_ocsentimentdailytopic(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_ocsentimentdailytopic(Entity entity, Entity merge)
		{
			Entity = entity;
			foreach (var property in merge?.Attributes)
			{
				var key = property.Key;
				var value = property.Value;
				Entity[key] = value;
			}
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_ocsentimentdailytopic(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedBy); }
		}

		/// <summary>
		/// <para>Date and time when the record was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who created the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Sequence number of the import that created this record.</para>
		/// <para>Integer - MinValue: -2,147,483,648 - MaxValue: 2,147,483,647</para>
		/// <para>Import Sequence Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? ImportSequenceNumber
		{
			get { return Entity.GetAttributeValue<int?>(Fields.ImportSequenceNumber); }
			set { Entity.Attributes[Fields.ImportSequenceNumber] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the user who modified the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedBy); }
		}

		/// <summary>
		/// <para>Date and time when the record was modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who modified the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>The volume of chat sessions within this topic cluster</para>
		/// <para>Required - Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Conversation count</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_conversationcount
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_conversationcount); }
			set { Entity.Attributes[Fields.msdyn_conversationcount] = value; }
		}

		/// <summary>
		/// <para>3 Chat conversation examples from this topic cluster</para>
		/// <para>Required - String - MaxLength: 4000</para>
		/// <para>Conversation example</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_conversationexample
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_conversationexample); }
			set { Entity.Attributes[Fields.msdyn_conversationexample] = value; }
		}

		/// <summary>
		/// <para>The name of the custom entity.</para>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_name
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_name); }
			set { Entity.Attributes[Fields.msdyn_name] = value; }
		}

		/// <summary>
		/// <para>Daily Topic  Id</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Topic Unique Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_ocsentimentdailytopicId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_ocsentimentdailytopicId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Intraday sentiment driver: The sentiment weighted  impact value from this topic cluster on the day’s average sentiment score</para>
		/// <para>Double - MinValue: -100 - MaxValue: 100</para>
		/// <para>Sentiment driver intraday weight impact</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public double? msdyn_sentimentdriverintradayweightimpact
		{
			get { return Entity.GetAttributeValue<double?>(Fields.msdyn_sentimentdriverintradayweightimpact); }
			set { Entity.Attributes[Fields.msdyn_sentimentdriverintradayweightimpact] = value; }
		}

		/// <summary>
		/// <para>The average sentiment score for all the chat sessions within the topic cluster</para>
		/// <para>Required - Double - MinValue: 0 - MaxValue: 1,000,000,000</para>
		/// <para>Sentiment score</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public double? msdyn_sentimentscore
		{
			get { return Entity.GetAttributeValue<double?>(Fields.msdyn_sentimentscore); }
			set { Entity.Attributes[Fields.msdyn_sentimentscore] = value; }
		}

		/// <summary>
		/// <para>The percentage of this topic chat session volume in the total daily chat session volume</para>
		/// <para>Required - Double - MinValue: 0 - MaxValue: 1,000,000,000</para>
		/// <para>Topic count percentage</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public double? msdyn_topiccountpercentage
		{
			get { return Entity.GetAttributeValue<double?>(Fields.msdyn_topiccountpercentage); }
			set { Entity.Attributes[Fields.msdyn_topiccountpercentage] = value; }
		}

		/// <summary>
		/// <para>Date of the Topic</para>
		/// <para>Required - DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Topic date</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_topicdateUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_topicdate); }
			set { Entity.Attributes[Fields.msdyn_topicdate] = value; }
		}

		/// <summary>
		/// <para>The topic cluster id from clustering algorithm -1 represent outlier cluster Positive number like 5 represent topic cluster</para>
		/// <para>Integer - MinValue: -100 - MaxValue: 2,147,483,647</para>
		/// <para>Topic index</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_topicindex
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_topicindex); }
			set { Entity.Attributes[Fields.msdyn_topicindex] = value; }
		}

		/// <summary>
		/// <para>A combination of top noun keyword and verb keyword, which is used for dashboard visualization</para>
		/// <para>Required - String - MaxLength: 4000</para>
		/// <para>Topic name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_topicname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_topicname); }
			set { Entity.Attributes[Fields.msdyn_topicname] = value; }
		}

		/// <summary>
		/// <para>Weekly Id for the topic</para>
		/// <para>Required - String - MaxLength: 4000</para>
		/// <para>Weekly id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_weeklyid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_weeklyid); }
			set { Entity.Attributes[Fields.msdyn_weeklyid] = value; }
		}

		/// <summary>
		/// <para>Weekly TopicId for the topic</para>
		/// <para>Required - String - MaxLength: 4000</para>
		/// <para>Weekly topic id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_weeklytopicid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_weeklytopicid); }
			set { Entity.Attributes[Fields.msdyn_weeklytopicid] = value; }
		}

		/// <summary>
		/// <para>Weekly Topic Name for the topic</para>
		/// <para>Required - String - MaxLength: 4000</para>
		/// <para>Weekly topic name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_weeklytopicname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_weeklytopicname); }
			set { Entity.Attributes[Fields.msdyn_weeklytopicname] = value; }
		}

		/// <summary>
		/// <para>Date and time that the record was migrated.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Record Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? OverriddenCreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.OverriddenCreatedOn); }
			set { Entity.Attributes[Fields.OverriddenCreatedOn] = value; }
		}

		/// <summary>
		/// <para>Owner Id</para>
		/// <para>Owner</para>
		/// <para>Owner</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwnerId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwnerId); }
			set { Entity.Attributes[Fields.OwnerId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for the business unit that owns the record</para>
		/// <para>ReadOnly - Lookup to businessunit</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier for the team that owns the record.</para>
		/// <para>ReadOnly - Lookup to team</para>
		/// <para>Owning Team</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningTeam
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningTeam); }
		}

		/// <summary>
		/// <para>Unique identifier for the user that owns the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>Status of the Sentiment daily topic</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_ocsentimentdailytopicOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_ocsentimentdailytopicOptionSets.statecode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.statecode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.statecode] = null;
			}
		}

		/// <summary>
		/// <para>Reason for the status of the Sentiment daily topic</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_ocsentimentdailytopicOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_ocsentimentdailytopicOptionSets.statuscode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.statuscode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.statuscode] = null;
			}
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>Integer - MinValue: -1 - MaxValue: 2,147,483,647</para>
		/// <para>Time Zone Rule Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? TimeZoneRuleVersionNumber
		{
			get { return Entity.GetAttributeValue<int?>(Fields.TimeZoneRuleVersionNumber); }
			set { Entity.Attributes[Fields.TimeZoneRuleVersionNumber] = value; }
		}

		/// <summary>
		/// <para>Time zone code that was in use when the record was created.</para>
		/// <para>Integer - MinValue: -1 - MaxValue: 2,147,483,647</para>
		/// <para>UTC Conversion Time Zone Code</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? UTCConversionTimeZoneCode
		{
			get { return Entity.GetAttributeValue<int?>(Fields.UTCConversionTimeZoneCode); }
			set { Entity.Attributes[Fields.UTCConversionTimeZoneCode] = value; }
		}

		/// <summary>
		/// <para>Version Number</para>
		/// <para>ReadOnly - BigInt</para>
		/// <para>Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public long? VersionNumber
		{
			get { return Entity.GetAttributeValue<long?>(Fields.VersionNumber); }
		}
	}
}
