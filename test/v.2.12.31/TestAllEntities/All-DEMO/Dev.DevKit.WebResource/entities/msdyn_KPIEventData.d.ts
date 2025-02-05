﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace Formmsdyn_KPIEventData_Information {
		interface Tabs {
		}
		interface Body {
			/** Required name field */
			msdyn_Name: DevKit.Controls.String;
			/** Owner Id */
			OwnerId: DevKit.Controls.Lookup;
		}
	}
	class Formmsdyn_KPIEventData_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_KPIEventData_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_KPIEventData_Information */
		Body: DevKit.Formmsdyn_KPIEventData_Information.Body;
	}
	class msdyn_KPIEventDataApi {
		/**
		* DynamicsCrm.DevKit msdyn_KPIEventDataApi
		* @param entity The entity object
		*/
		constructor(entity?: any);
		/**
		 * Get the value of alias
		 * @param alias the alias value
		 * @param isMultiOptionSet true if the alias is multi OptionSet
		 */
		getAliasedValue(alias: string, isMultiOptionSet?: boolean): any;
		/**
		 * Get the formatted value of alias
		 * @param alias the alias value
		 * @param isMultiOptionSet true if the alias is multi OptionSet
		 */
		getAliasedFormattedValue(alias: string, isMultiOptionSet?: boolean): string;
		/** The entity object */
		Entity: any;
		/** The entity name */
		EntityName: string;
		/** The entity collection name */
		EntityCollectionName: string;
		/** The @odata.etag is then used to build a cache of the response that is dependant on the fields that are retrieved */
		"@odata.etag": string;
		/** Unique identifier of the user who created the record. */
		CreatedBy: DevKit.WebApi.LookupValueReadonly;
		/** Date and time when the record was created. */
		CreatedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Unique identifier of the delegate user who created the record. */
		CreatedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Sequence number of the import that created this record. */
		ImportSequenceNumber: DevKit.WebApi.IntegerValue;
		/** Unique identifier of the user who modified the record. */
		ModifiedBy: DevKit.WebApi.LookupValueReadonly;
		/** Date and time when the record was modified. */
		ModifiedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Unique identifier of the delegate user who modified the record. */
		ModifiedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Additional data related to the kpi event */
		msdyn_AdditionalData: DevKit.WebApi.StringValue;
		/** Unique identifier for Channel Integration Framework session */
		msdyn_cifSessionId: DevKit.WebApi.StringValue;
		/** Client session identifier */
		msdyn_ClientSessionId: DevKit.WebApi.StringValue;
		/** Conversation Identifier */
		msdyn_ConversationId: DevKit.WebApi.StringValue;
		/** Custom Attribute 1 */
		msdyn_CustomAttribute1: DevKit.WebApi.StringValue;
		/** Custom Attribute 2 */
		msdyn_CustomAttribute2: DevKit.WebApi.StringValue;
		/** Custom Attribute 3 */
		msdyn_CustomAttribute3: DevKit.WebApi.StringValue;
		/** Custom Attribute 4 */
		msdyn_CustomAttribute4: DevKit.WebApi.StringValue;
		/** Custom Attribute 5 */
		msdyn_CustomAttribute5: DevKit.WebApi.StringValue;
		/** Timestamp at which the event occurred */
		msdyn_EventTimestamp_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValue;
		/** External System Correlation Id */
		msdyn_ExternalCorrelationId: DevKit.WebApi.StringValue;
		/** Unique identifier for entity instances */
		msdyn_KPIEventDataId: DevKit.WebApi.GuidValue;
		/** Unique identifier for the KPI Event */
		msdyn_KPIEventId: DevKit.WebApi.StringValue;
		/** Name of the  associated KPI event */
		msdyn_KPIEventName: DevKit.WebApi.StringValue;
		/** Reason due to which the KPI event was created */
		msdyn_KPIEventReason: DevKit.WebApi.StringValue;
		/** Required name field */
		msdyn_Name: DevKit.WebApi.StringValue;
		/** Identifier of the agent for whom the event was fired */
		msdyn_ParticipantId: DevKit.WebApi.StringValue;
		/** Unique identifier of the Provider that triggered this event */
		msdyn_ProviderId: DevKit.WebApi.StringValue;
		/** Unique identifier of the provider session */
		msdyn_ProviderSessionId: DevKit.WebApi.StringValue;
		/** Unique identifier for session */
		msdyn_sessionId: DevKit.WebApi.StringValue;
		/** Date and time that the record was migrated. */
		OverriddenCreatedOn_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user */
		OwnerId_systemuser: DevKit.WebApi.LookupValue;
		/** Enter the team who is assigned to manage the record. This field is updated every time the record is assigned to a different team */
		OwnerId_team: DevKit.WebApi.LookupValue;
		/** Unique identifier for the business unit that owns the record */
		OwningBusinessUnit: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier for the team that owns the record. */
		OwningTeam: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier for the user that owns the record. */
		OwningUser: DevKit.WebApi.LookupValueReadonly;
		/** Status of the KPI Event Data */
		statecode: DevKit.WebApi.OptionSetValue;
		/** Reason for the status of the KPI Event Data */
		statuscode: DevKit.WebApi.OptionSetValue;
		/** For internal use only. */
		TimeZoneRuleVersionNumber: DevKit.WebApi.IntegerValue;
		/** Time zone code that was in use when the record was created. */
		UTCConversionTimeZoneCode: DevKit.WebApi.IntegerValue;
		/** Version Number */
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
	}
}
declare namespace OptionSet {
	namespace msdyn_KPIEventData {
		enum statecode {
			/** 0 */
			Active,
			/** 1 */
			Inactive
		}
		enum statuscode {
			/** 1 */
			Active,
			/** 2 */
			Inactive
		}
        enum RollupState {
            /** 0 - Attribute value is yet to be calculated */
            NotCalculated,
            /** 1 - Attribute value has been calculated per the last update time in <AttributeSchemaName>_Date attribute */
            Calculated,
            /** 2 - Attribute value calculation lead to overflow error */
            OverflowError,
            /** 3 - Attribute value calculation failed due to an internal error, next run of calculation job will likely fix it */
            OtherError,
            /** 4 - Attribute value calculation failed because the maximum number of retry attempts to calculate the value were exceeded likely due to high number of concurrency and locking conflicts */
            RetryLimitExceeded,
            /** 5 - Attribute value calculation failed because maximum hierarchy depth limit for calculation was reached */
            HierarchicalRecursionLimitReached,
            /** 6 - Attribute value calculation failed because a recursive loop was detected in the hierarchy of the record */
            LoopDetected
        }
	}
}
//{'JsForm':['Information'],'JsWebApi':true,'IsDebugForm':true,'IsDebugWebApi':true,'Version':'2.12.31','JsFormVersion':'v2'}