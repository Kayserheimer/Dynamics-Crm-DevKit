﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.LuckyStar2.Shared.Entities.TimeStampDateMappingOptionSets
{

}

namespace Abc.LuckyStar2.Shared.Entities
{
	public partial class TimeStampDateMapping : EntityBase
	{
		public struct Fields
		{
			public const string Date = "date";
			public const string TimeStamp = "timestamp";
			public const string TimeStampDateMappingId = "timestampdatemappingid";
		}

		public const string EntityLogicalName = "timestampdatemapping";

		public const int EntityTypeCode = 9932;

		[DebuggerNonUserCode()]
		public TimeStampDateMapping()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TimeStampDateMapping(Guid TimeStampDateMappingId)
		{
			Entity = new Entity(EntityLogicalName, TimeStampDateMappingId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TimeStampDateMapping(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TimeStampDateMapping(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TimeStampDateMapping(Entity entity, Entity merge)
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
		public TimeStampDateMapping(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? DateUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.Date); }
		}

		/// <summary>
		/// <para>ReadOnly - BigInt</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public long? TimeStamp
		{
			get { return Entity.GetAttributeValue<long?>(Fields.TimeStamp); }
		}

		/// <summary>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid TimeStampDateMappingId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.TimeStampDateMappingId] = value;
				Entity.Id = value;
			}
		}
	}
}
