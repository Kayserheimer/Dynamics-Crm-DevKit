﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.LuckyStar2.Shared.Entities.RoleTemplatePrivilegesOptionSets
{

}

namespace Abc.LuckyStar2.Shared.Entities
{
	public partial class RoleTemplatePrivileges : EntityBase
	{
		public struct Fields
		{
			public const string IsBasic = "isbasic";
			public const string IsDeep = "isdeep";
			public const string IsGlobal = "isglobal";
			public const string IsLocal = "islocal";
			public const string PrivilegeId = "privilegeid";
			public const string RoleTemplateId = "roletemplateid";
			public const string RoleTemplatePrivilegeId = "roletemplateprivilegeid";
			public const string Upgrading = "upgrading";
		}

		public const string EntityLogicalName = "roletemplateprivileges";

		public const int EntityTypeCode = 28;

		[DebuggerNonUserCode()]
		public RoleTemplatePrivileges()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public RoleTemplatePrivileges(Guid RoleTemplatePrivilegesId)
		{
			Entity = new Entity(EntityLogicalName, RoleTemplatePrivilegesId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public RoleTemplatePrivileges(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public RoleTemplatePrivileges(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public RoleTemplatePrivileges(Entity entity, Entity merge)
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
		public RoleTemplatePrivileges(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Information about whether the role in the template applies to the user, the user's team, or objects shared by the user.</para>
		/// <para>Boolean</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsBasic
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsBasic); }
			set { Entity.Attributes[Fields.IsBasic] = value; }
		}

		/// <summary>
		/// <para>Information about whether the role in the template applies to child business units of the business unit associated with the user.</para>
		/// <para>Boolean</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsDeep
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsDeep); }
			set { Entity.Attributes[Fields.IsDeep] = value; }
		}

		/// <summary>
		/// <para>Information about whether the role in the template applies to the entire organization.</para>
		/// <para>Boolean</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsGlobal
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsGlobal); }
			set { Entity.Attributes[Fields.IsGlobal] = value; }
		}

		/// <summary>
		/// <para>Information about whether the role in the template applies to the user's business unit.</para>
		/// <para>Boolean</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsLocal
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsLocal); }
			set { Entity.Attributes[Fields.IsLocal] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the privilege assigned to the role template.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? PrivilegeId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.PrivilegeId); }
		}

		/// <summary>
		/// <para>Unique identifier of the role template that is associated with the role privilege.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? RoleTemplateId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.RoleTemplateId); }
		}

		/// <summary>
		/// <para>Unique identifier of the role template privileges.</para>
		/// <para>Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? RoleTemplatePrivilegeId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.RoleTemplatePrivilegeId); }
			set { Entity.Attributes[Fields.RoleTemplatePrivilegeId] = value; }
		}

		/// <summary>
		/// <para>ReadOnly - Boolean</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? Upgrading
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.Upgrading); }
		}
	}
}
