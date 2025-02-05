﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.ConstraintBasedGroupOptionSets
{
	public enum GroupTypeCode
	{
		/// <summary>
		/// Dynamic = 1
		/// </summary>
		Dynamic = 1,
		/// <summary>
		/// Hidden = 2
		/// </summary>
		Hidden = 2,
		/// <summary>
		/// Static = 0
		/// </summary>
		Static = 0
	}
}

namespace Dev.DevKit.Shared.Entities
{
	public partial class ConstraintBasedGroup : EntityBase
	{
		public struct Fields
		{
			public const string BusinessUnitId = "businessunitid";
			public const string ConstraintBasedGroupId = "constraintbasedgroupid";
			public const string Constraints = "constraints";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string GroupTypeCode = "grouptypecode";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "constraintbasedgroup";

		public const int EntityTypeCode = 4007;

		[DebuggerNonUserCode()]
		public ConstraintBasedGroup()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ConstraintBasedGroup(Guid ConstraintBasedGroupId)
		{
			Entity = new Entity(EntityLogicalName, ConstraintBasedGroupId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ConstraintBasedGroup(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ConstraintBasedGroup(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ConstraintBasedGroup(Entity entity, Entity merge)
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
		public ConstraintBasedGroup(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Shows the business unit that the record owner belongs to.</para>
		/// <para>Lookup to businessunit</para>
		/// <para>Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference BusinessUnitId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.BusinessUnitId); }
			set { Entity.Attributes[Fields.BusinessUnitId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the resource group.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Resource Group</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid ConstraintBasedGroupId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.ConstraintBasedGroupId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Shows the constraints defined for the users, equipment, teams, and other resource groups included as resources for the group, stored in XML format.</para>
		/// <para>String - MaxLength: 1073741823</para>
		/// <para>Constraints</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Constraints
		{
			get { return Entity.GetAttributeValue<string>(Fields.Constraints); }
			set { Entity.Attributes[Fields.Constraints] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the resource group.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedBy); }
		}

		/// <summary>
		/// <para>Date and time when the resource group was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who created the constraintbasedgroup.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Type additional information to describe the resource group, such as the intended use or associated resource types.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para>Description</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Description
		{
			get { return Entity.GetAttributeValue<string>(Fields.Description); }
			set { Entity.Attributes[Fields.Description] = value; }
		}

		/// <summary>
		/// <para>Shows whether the resource group is static, dynamic or hidden. Hidden groups are for system use only and are not viewable in Microsoft Dynamics 365.</para>
		/// <para>Picklist</para>
		/// <para>Group Type</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.ConstraintBasedGroupOptionSets.GroupTypeCode? GroupTypeCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.GroupTypeCode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.ConstraintBasedGroupOptionSets.GroupTypeCode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.GroupTypeCode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.GroupTypeCode] = null;
			}
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
		/// <para>Unique identifier of the user who last modified the resource group.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedBy); }
		}

		/// <summary>
		/// <para>Date and time when the resource group was last modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who last modified the constraintbasedgroup.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Type a title or name that describes the resource group.</para>
		/// <para>String - MaxLength: 160</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.Name); }
			set { Entity.Attributes[Fields.Name] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the organization associated with the resource group.</para>
		/// <para>ReadOnly - Lookup to organization</para>
		/// <para>Organization</para>
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
