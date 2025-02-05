﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.EntityAnalyticsConfigOptionSets
{
	public enum ComponentState
	{
		/// <summary>
		/// Deleted = 2
		/// </summary>
		Deleted = 2,
		/// <summary>
		/// Deleted_Unpublished = 3
		/// </summary>
		Deleted_Unpublished = 3,
		/// <summary>
		/// Published = 0
		/// </summary>
		Published = 0,
		/// <summary>
		/// Unpublished = 1
		/// </summary>
		Unpublished = 1
	}
}

namespace Dev.DevKit.Shared.Entities
{
	public partial class EntityAnalyticsConfig : EntityBase
	{
		public struct Fields
		{
			public const string ComponentIdUnique = "componentidunique";
			public const string ComponentState = "componentstate";
			public const string CreatedOn = "createdon";
			public const string EntityAnalyticsConfigId = "entityanalyticsconfigid";
			public const string IsEnabledForADLS = "isenabledforadls";
			public const string IsEnabledForTimeSeries = "isenabledfortimeseries";
			public const string IsManaged = "ismanaged";
			public const string ModifiedOn = "modifiedon";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string ParentEntityId = "parententityid";
			public const string ParentEntityLogicalName = "parententitylogicalname";
			public const string SolutionId = "solutionid";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "entityanalyticsconfig";

		public const int EntityTypeCode = 430;

		[DebuggerNonUserCode()]
		public EntityAnalyticsConfig()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public EntityAnalyticsConfig(Guid EntityAnalyticsConfigId)
		{
			Entity = new Entity(EntityLogicalName, EntityAnalyticsConfigId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public EntityAnalyticsConfig(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public EntityAnalyticsConfig(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public EntityAnalyticsConfig(Entity entity, Entity merge)
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
		public EntityAnalyticsConfig(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Row id unique</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? ComponentIdUnique
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.ComponentIdUnique); }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Picklist</para>
		/// <para>Component State</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.EntityAnalyticsConfigOptionSets.ComponentState? ComponentState
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ComponentState);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.EntityAnalyticsConfigOptionSets.ComponentState)value.Value;
			}
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
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Entity Analytics Config</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid EntityAnalyticsConfigId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.EntityAnalyticsConfigId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Azure Data Lake Storage is enabled for the selected entity</para>
		/// <para>Boolean</para>
		/// <para>Is Enabled For ADLS</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsEnabledForADLS
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsEnabledForADLS); }
			set { Entity.Attributes[Fields.IsEnabledForADLS] = value; }
		}

		/// <summary>
		/// <para>Time series is enabled for the selected entity</para>
		/// <para>Boolean</para>
		/// <para>Is Enabled For Time Series</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsEnabledForTimeSeries
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsEnabledForTimeSeries); }
			set { Entity.Attributes[Fields.IsEnabledForTimeSeries] = value; }
		}

		/// <summary>
		/// <para>Indicates whether the solution component is part of a managed solution.</para>
		/// <para>ReadOnly - Boolean</para>
		/// <para>Is Managed</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsManaged
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsManaged); }
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
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Record Overwrite Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? OverwriteTimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.OverwriteTime); }
		}

		/// <summary>
		/// <para>Unique identifier for Entity associated with Entity Analytics Config.</para>
		/// <para>Lookup to entity</para>
		/// <para>Parent Entity Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ParentEntityId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ParentEntityId); }
			set { Entity.Attributes[Fields.ParentEntityId] = value; }
		}

		/// <summary>
		/// <para>Entity Logical Name For Analytics</para>
		/// <para>String - MaxLength: 128</para>
		/// <para>Entity Logical Name For Analytics</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string ParentEntityLogicalName
		{
			get { return Entity.GetAttributeValue<string>(Fields.ParentEntityLogicalName); }
			set { Entity.Attributes[Fields.ParentEntityLogicalName] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the associated solution.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Solution</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? SolutionId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.SolutionId); }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Solution</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? SupportingSolutionId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.SupportingSolutionId); }
		}

		/// <summary>
		/// <para>Version number of Entity Analytics Config.</para>
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
