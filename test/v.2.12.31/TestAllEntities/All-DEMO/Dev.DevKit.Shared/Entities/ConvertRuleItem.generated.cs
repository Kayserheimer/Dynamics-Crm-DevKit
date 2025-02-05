﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.ConvertRuleItemOptionSets
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
	public partial class ConvertRuleItem : EntityBase
	{
		public struct Fields
		{
			public const string ComponentState = "componentstate";
			public const string ConditionId = "conditionid";
			public const string ConditionXml = "conditionxml";
			public const string ConvertRuleId = "convertruleid";
			public const string ConvertRuleItemId = "convertruleitemid";
			public const string ConvertRuleItemIdUnique = "convertruleitemidunique";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string ExchangeRate = "exchangerate";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OverwriteTime = "overwritetime";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string PrimaryCreateEntityLogicalName = "primarycreateentitylogicalname";
			public const string PropertiesXml = "propertiesxml";
			public const string QueueId = "queueid";
			public const string SequenceNumber = "sequencenumber";
			public const string SolutionId = "solutionid";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
			public const string WorkflowId = "workflowid";
		}

		public const string EntityLogicalName = "convertruleitem";

		public const int EntityTypeCode = 9301;

		[DebuggerNonUserCode()]
		public ConvertRuleItem()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ConvertRuleItem(Guid ConvertRuleItemId)
		{
			Entity = new Entity(EntityLogicalName, ConvertRuleItemId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ConvertRuleItem(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ConvertRuleItem(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ConvertRuleItem(Entity entity, Entity merge)
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
		public ConvertRuleItem(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Picklist</para>
		/// <para>Component State</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.ConvertRuleItemOptionSets.ComponentState? ComponentState
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ComponentState);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.ConvertRuleItemOptionSets.ComponentState)value.Value;
			}
		}

		/// <summary>
		/// <para>Identifies the step of the associated workflow</para>
		/// <para>Required - Lookup to workflow</para>
		/// <para>Condition</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ConditionId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ConditionId); }
			set { Entity.Attributes[Fields.ConditionId] = value; }
		}

		/// <summary>
		/// <para>Condition for convert rule item</para>
		/// <para>Required - Memo - MaxLength: 1073741823</para>
		/// <para>ConditionXml</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string ConditionXml
		{
			get { return Entity.GetAttributeValue<string>(Fields.ConditionXml); }
			set { Entity.Attributes[Fields.ConditionXml] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the convert rule associated with the convert rule item.</para>
		/// <para>Lookup to convertrule</para>
		/// <para>Show the conversion rule associated to this rule item</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ConvertRuleId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ConvertRuleId); }
			set { Entity.Attributes[Fields.ConvertRuleId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Routing Rule</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid ConvertRuleItemId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.ConvertRuleItemId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Unique Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? ConvertRuleItemIdUnique
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.ConvertRuleItemIdUnique); }
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
		/// <para>Shows who created the record on behalf of another user.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Type additional information to describe the rule item for automatic record creation.</para>
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
		/// <para>Exchange rate for the currency associated with the queue with respect to the base currency.</para>
		/// <para>ReadOnly - Decimal - MinValue: 0 - MaxValue: 100,000,000,000</para>
		/// <para>Exchange Rate</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? ExchangeRate
		{
			get { return Entity.GetAttributeValue<decimal?>(Fields.ExchangeRate); }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Boolean</para>
		/// <para>Is Managed</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsManaged
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsManaged); }
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
		/// <para>Shows who created the record on behalf of another user.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Type a name or title of the rule item that is used for automatic record creation and update.</para>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.Name); }
			set { Entity.Attributes[Fields.Name] = value; }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Record Overwrite Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? OverwriteTimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.OverwriteTime); }
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
		/// <para>Shows the business unit that the convert rule item owner belongs to.</para>
		/// <para>ReadOnly - Lookup to businessunit</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who owns the Convert Rule Item.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>Primary create entity for a rule item</para>
		/// <para>String - MaxLength: 500</para>
		/// <para>Primary Create Entity Logical Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string PrimaryCreateEntityLogicalName
		{
			get { return Entity.GetAttributeValue<string>(Fields.PrimaryCreateEntityLogicalName); }
			set { Entity.Attributes[Fields.PrimaryCreateEntityLogicalName] = value; }
		}

		/// <summary>
		/// <para>Set properties xml for convert rule item</para>
		/// <para>Memo - MaxLength: 1073741823</para>
		/// <para>SetPropertiesXml</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string PropertiesXml
		{
			get { return Entity.GetAttributeValue<string>(Fields.PropertiesXml); }
			set { Entity.Attributes[Fields.PropertiesXml] = value; }
		}

		/// <summary>
		/// <para>Choose the queue that the rule is assigned to.</para>
		/// <para>Lookup to queue</para>
		/// <para>Queue</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference QueueId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.QueueId); }
			set { Entity.Attributes[Fields.QueueId] = value; }
		}

		/// <summary>
		/// <para>Sequence number of the convert rule item</para>
		/// <para>Integer - MinValue: -2,147,483,648 - MaxValue: 2,147,483,647</para>
		/// <para>Sequence Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? SequenceNumber
		{
			get { return Entity.GetAttributeValue<int?>(Fields.SequenceNumber); }
			set { Entity.Attributes[Fields.SequenceNumber] = value; }
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
		/// <para>Choose the local currency for the record to make sure budgets are reported in the correct currency.</para>
		/// <para>ReadOnly - Lookup to transactioncurrency</para>
		/// <para>Currency</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference TransactionCurrencyId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.TransactionCurrencyId); }
		}

		/// <summary>
		/// <para>Version number of the Covert Rule Item.</para>
		/// <para>ReadOnly - BigInt</para>
		/// <para>Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public long? VersionNumber
		{
			get { return Entity.GetAttributeValue<long?>(Fields.VersionNumber); }
		}

		/// <summary>
		/// <para>Workflow associated with the Convert Rule Item.</para>
		/// <para>Lookup to workflow</para>
		/// <para>Workflow ID</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference WorkflowId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.WorkflowId); }
			set { Entity.Attributes[Fields.WorkflowId] = value; }
		}
	}
}
