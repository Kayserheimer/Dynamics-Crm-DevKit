﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace FormPostFollow_Information {
		interface tab_general_Sections {
			Follow_information: DevKit.Controls.Section;
		}
		interface tab_general extends DevKit.Controls.ITab {
			Section: tab_general_Sections;
		}
		interface Tabs {
			general: tab_general;
		}
		interface Body {
			Tab: Tabs;
			/** Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. */
			OwnerId: DevKit.Controls.Lookup;
			/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
			RegardingObjectId: DevKit.Controls.Lookup;
		}
	}
	class FormPostFollow_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form PostFollow_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form PostFollow_Information */
		Body: DevKit.FormPostFollow_Information.Body;
	}
	class PostFollowApi {
		/**
		* DynamicsCrm.DevKit PostFollowApi
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
		/** Shows who created the record. */
		CreatedBy: DevKit.WebApi.LookupValueReadonly;
		/** Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. */
		CreatedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Shows who created the record on behalf of another user. */
		CreatedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user */
		OwnerId_systemuser: DevKit.WebApi.LookupValue;
		/** Enter the team who is assigned to manage the record. This field is updated every time the record is assigned to a different team */
		OwnerId_team: DevKit.WebApi.LookupValue;
		/** Unique identifier for the business unit that owns the record. */
		OwningBusinessUnit: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier of the team who owns the follow. */
		OwningTeam: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier for the user who owns the record. */
		OwningUser: DevKit.WebApi.LookupValueReadonly;
		/** Shows the ID of the post follow. */
		PostFollowId: DevKit.WebApi.GuidValue;
		/** Internal Use Only */
		PostToYammer: DevKit.WebApi.BooleanValueReadonly;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_account: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_appointment: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_competitor: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_contact: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_incident: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_knowledgearticle: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_lead: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_opportunity: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_phonecall: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_processsession: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_queue: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_recurringappointmentmaster: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_systemuser: DevKit.WebApi.LookupValue;
		/** Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to. */
		regardingobjectid_task: DevKit.WebApi.LookupValue;
		/** For internal use only. */
		TimeZoneRuleVersionNumber: DevKit.WebApi.IntegerValue;
		/** Time zone code that was in use when the record was created. */
		UTCConversionTimeZoneCode: DevKit.WebApi.IntegerValue;
		/** Version number of post follow. */
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
		/** Internal Use Only */
		YammerPostState: DevKit.WebApi.IntegerValueReadonly;
		/** Internal Use Only */
		YammerRetryCount: DevKit.WebApi.IntegerValueReadonly;
	}
}
declare namespace OptionSet {
	namespace PostFollow {
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