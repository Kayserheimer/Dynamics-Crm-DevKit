﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_upgradestepOptionSets
{
	public enum msdyn_Status
	{
		/// <summary>
		/// Failure = 100000002
		/// </summary>
		Failure = 100000002,
		/// <summary>
		/// Started = 100000000
		/// </summary>
		Started = 100000000,
		/// <summary>
		/// Success = 100000001
		/// </summary>
		Success = 100000001
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
	public partial class msdyn_upgradestep : EntityBase
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
			public const string msdyn_dbversion = "msdyn_dbversion";
			public const string msdyn_Details = "msdyn_details";
			public const string msdyn_Errors = "msdyn_errors";
			public const string msdyn_FinishedDate = "msdyn_finished";
			public const string msdyn_Name = "msdyn_name";
			public const string msdyn_Status = "msdyn_status";
			public const string msdyn_StepID = "msdyn_stepid";
			public const string msdyn_upgradestepId = "msdyn_upgradestepid";
			public const string msdyn_UpgradeVersion = "msdyn_upgradeversion";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "msdyn_upgradestep";

		public const int EntityTypeCode = 10105;

		[DebuggerNonUserCode()]
		public msdyn_upgradestep()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_upgradestep(Guid msdyn_upgradestepId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_upgradestepId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_upgradestep(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_upgradestep(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_upgradestep(Entity entity, Entity merge)
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
		public msdyn_upgradestep(KeyAttributeCollection keys)
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
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Started</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
			set { Entity.Attributes[Fields.CreatedOn] = value; }
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
		/// <para>Database version for internal use only</para>
		/// <para>Integer - MinValue: -2,147,483,648 - MaxValue: 2,147,483,647</para>
		/// <para>Database Version</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_dbversion
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_dbversion); }
			set { Entity.Attributes[Fields.msdyn_dbversion] = value; }
		}

		/// <summary>
		/// <para>Diagnostic output from an upgrade step</para>
		/// <para>Memo - MaxLength: 4000</para>
		/// <para>Details</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Details
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Details); }
			set { Entity.Attributes[Fields.msdyn_Details] = value; }
		}

		/// <summary>
		/// <para>Error text, if an error occurred during this step</para>
		/// <para>Memo - MaxLength: 4000</para>
		/// <para>Errors</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Errors
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Errors); }
			set { Entity.Attributes[Fields.msdyn_Errors] = value; }
		}

		/// <summary>
		/// <para>Date/time when an upgrade step finished</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Finished Date</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_FinishedDateUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_FinishedDate); }
			set { Entity.Attributes[Fields.msdyn_FinishedDate] = value; }
		}

		/// <summary>
		/// <para>Name of the method or stored procedure corresponding to an upgrade step</para>
		/// <para>Required - String - MaxLength: 200</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Name); }
			set { Entity.Attributes[Fields.msdyn_Name] = value; }
		}

		/// <summary>
		/// <para>Status/outcome of an upgrade step</para>
		/// <para>Required - Picklist</para>
		/// <para>Step Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_upgradestepOptionSets.msdyn_Status? msdyn_Status
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_Status);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_upgradestepOptionSets.msdyn_Status)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyn_Status] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>Required - Uniqueidentifier</para>
		/// <para>Step ID</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? msdyn_StepID
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.msdyn_StepID); }
			set { Entity.Attributes[Fields.msdyn_StepID] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Upgrade Step</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_upgradestepId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_upgradestepId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Single-version upgrade that contains this upgrade step</para>
		/// <para>Required - Lookup to msdyn_upgradeversion</para>
		/// <para>Upgrade Version</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_UpgradeVersion
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_UpgradeVersion); }
			set { Entity.Attributes[Fields.msdyn_UpgradeVersion] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for the organization</para>
		/// <para>ReadOnly - Lookup to organization</para>
		/// <para>Organization Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OrganizationId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OrganizationId); }
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
		/// <para>Status of the UpgradeStep</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_upgradestepOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_upgradestepOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the UpgradeStep</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_upgradestepOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_upgradestepOptionSets.statuscode)value.Value;
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
