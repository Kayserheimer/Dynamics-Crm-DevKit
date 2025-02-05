﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_ocsitrainingdataOptionSets
{
	public enum msdyn_ocsitrainingdatastatus
	{
		/// <summary>
		/// Approved = 326340000
		/// </summary>
		Approved = 326340000,
		/// <summary>
		/// Needs_further_investigation = 326340002
		/// </summary>
		Needs_further_investigation = 326340002,
		/// <summary>
		/// Pending = 326340001
		/// </summary>
		Pending = 326340001
	}

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
	public partial class msdyn_ocsitrainingdata : EntityBase
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
			public const string msdyn_approvedby = "msdyn_approvedby";
			public const string msdyn_approvedon = "msdyn_approvedon";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_ocsitdimportconfigid = "msdyn_ocsitdimportconfigid";
			public const string msdyn_ocsitrainingdataId = "msdyn_ocsitrainingdataid";
			public const string msdyn_ocsitrainingdatastatus = "msdyn_ocsitrainingdatastatus";
			public const string msdyn_ocskillidentmlmodelid = "msdyn_ocskillidentmlmodelid";
			public const string msdyn_phrase = "msdyn_phrase";
			public const string msdyn_skillidscsv = "msdyn_skillidscsv";
			public const string msdyn_skillscsv = "msdyn_skillscsv";
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

		public const string EntityLogicalName = "msdyn_ocsitrainingdata";

		public const int EntityTypeCode = 10625;

		[DebuggerNonUserCode()]
		public msdyn_ocsitrainingdata()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_ocsitrainingdata(Guid msdyn_ocsitrainingdataId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_ocsitrainingdataId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_ocsitrainingdata(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_ocsitrainingdata(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_ocsitrainingdata(Entity entity, Entity merge)
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
		public msdyn_ocsitrainingdata(KeyAttributeCollection keys)
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
		/// <para>Import sequence version number</para>
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
		/// <para>Approved by</para>
		/// <para>Lookup to systemuser</para>
		/// <para>Approved by</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_approvedby
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_approvedby); }
			set { Entity.Attributes[Fields.msdyn_approvedby] = value; }
		}

		/// <summary>
		/// <para>Approved on</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Approved on</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_approvedonUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_approvedon); }
			set { Entity.Attributes[Fields.msdyn_approvedon] = value; }
		}

		/// <summary>
		/// <para>The name of the training record.</para>
		/// <para>Required - String - MaxLength: 2000</para>
		/// <para>Training record name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_name
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_name); }
			set { Entity.Attributes[Fields.msdyn_name] = value; }
		}

		/// <summary>
		/// <para>Data loading config</para>
		/// <para>Lookup to msdyn_ocsitdimportconfig</para>
		/// <para>Data loading config</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_ocsitdimportconfigid
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_ocsitdimportconfigid); }
			set { Entity.Attributes[Fields.msdyn_ocsitdimportconfigid] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for training record</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Training record id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_ocsitrainingdataId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_ocsitrainingdataId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Approval status</para>
		/// <para>Picklist</para>
		/// <para>Approval status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_ocsitrainingdataOptionSets.msdyn_ocsitrainingdatastatus? msdyn_ocsitrainingdatastatus
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_ocsitrainingdatastatus);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_ocsitrainingdataOptionSets.msdyn_ocsitrainingdatastatus)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_ocsitrainingdatastatus] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.msdyn_ocsitrainingdatastatus] = null;
			}
		}

		/// <summary>
		/// <para>Skill finder model</para>
		/// <para>Lookup to msdyn_ocskillidentmlmodel</para>
		/// <para>Skill finder model</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_ocskillidentmlmodelid
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_ocskillidentmlmodelid); }
			set { Entity.Attributes[Fields.msdyn_ocskillidentmlmodelid] = value; }
		}

		/// <summary>
		/// <para>Input data</para>
		/// <para>Memo - MaxLength: 5000</para>
		/// <para>Input data</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_phrase
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_phrase); }
			set { Entity.Attributes[Fields.msdyn_phrase] = value; }
		}

		/// <summary>
		/// <para>List of skill IDs</para>
		/// <para>Memo - MaxLength: 4000</para>
		/// <para>Skill IDs</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_skillidscsv
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_skillidscsv); }
			set { Entity.Attributes[Fields.msdyn_skillidscsv] = value; }
		}

		/// <summary>
		/// <para>Tags</para>
		/// <para>String - MaxLength: 4000</para>
		/// <para>Tags</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_skillscsv
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_skillscsv); }
			set { Entity.Attributes[Fields.msdyn_skillscsv] = value; }
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
		/// <para>Status of the ocsitrainingdata</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_ocsitrainingdataOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_ocsitrainingdataOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the ocsitrainingdata</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_ocsitrainingdataOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_ocsitrainingdataOptionSets.statuscode)value.Value;
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
