﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace Formmsdyn_consoleapplicationnotificationtemplate_Information {
		interface tab__9730037D_AB23_4A34_9B05_5A0E50E1C401_Sections {
			_9730037D_AB23_4A34_9B05_5A0E50E1C401_SECTION_2: DevKit.Controls.Section;
		}
		interface tab__9730037D_AB23_4A34_9B05_5A0E50E1C401 extends DevKit.Controls.ITab {
			Section: tab__9730037D_AB23_4A34_9B05_5A0E50E1C401_Sections;
		}
		interface Tabs {
			_9730037D_AB23_4A34_9B05_5A0E50E1C401: tab__9730037D_AB23_4A34_9B05_5A0E50E1C401;
		}
		interface Body {
			Tab: Tabs;
			/** Display label for the button to accept a notification */
			msdyn_AcceptButtonText: DevKit.Controls.String;
			msdyn_AutoAcceptNotification: DevKit.Controls.Boolean;
			/** Display icon for this notification. Can be either an image URL or a font-icon */
			msdyn_Icon: DevKit.Controls.String;
			msdyn_infosubheader: DevKit.Controls.ActionCards;
			/** The name of this Notification template. */
			msdyn_name: DevKit.Controls.String;
			msdyn_notificationbuttons: DevKit.Controls.ActionCards;
			msdyn_preview: DevKit.Controls.ActionCards;
			msdyn_RejectButtonAutoAccept: DevKit.Controls.Boolean;
			/** Display label for the button to reject a notification */
			msdyn_RejectButtonText: DevKit.Controls.String;
			/** Show countdown for when the notification will disappear */
			msdyn_Showtimeout: DevKit.Controls.OptionSet;
			/** Theme color for Notification template. */
			msdyn_Theme: DevKit.Controls.OptionSet;
			/** Notification time out period. */
			msdyn_Timeout: DevKit.Controls.Integer;
			/** The title to be displayed for this notification. */
			msdyn_Title: DevKit.Controls.String;
		}
		interface Navigation {
			nav_msdyn_msdyn_consoleapplicationnotificationtag: DevKit.Controls.NavigationItem
		}
		interface Grid {
			NotificationFields: DevKit.Controls.Grid;
		}
	}
	class Formmsdyn_consoleapplicationnotificationtemplate_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_consoleapplicationnotificationtemplate_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_consoleapplicationnotificationtemplate_Information */
		Body: DevKit.Formmsdyn_consoleapplicationnotificationtemplate_Information.Body;
		/** The Navigation of form msdyn_consoleapplicationnotificationtemplate_Information */
		Navigation: DevKit.Formmsdyn_consoleapplicationnotificationtemplate_Information.Navigation;
		/** The Grid of form msdyn_consoleapplicationnotificationtemplate_Information */
		Grid: DevKit.Formmsdyn_consoleapplicationnotificationtemplate_Information.Grid;
	}
	class msdyn_consoleapplicationnotificationtemplateApi {
		/**
		* DynamicsCrm.DevKit msdyn_consoleapplicationnotificationtemplateApi
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
		/** Display label for the button to accept a notification */
		msdyn_AcceptButtonText: DevKit.WebApi.StringValue;
		/** The action buttons to be displayed. (Deprecated) */
		msdyn_ActionButtons: DevKit.WebApi.MultiOptionSetValue;
		msdyn_AutoAcceptNotification: DevKit.WebApi.BooleanValue;
		/** Unique identifier for entity instances */
		msdyn_consoleapplicationnotificationtemplateId: DevKit.WebApi.GuidValue;
		/** Display icon for this notification. Can be either an image URL or a font-icon */
		msdyn_Icon: DevKit.WebApi.StringValue;
		/** The name of this Notification template. */
		msdyn_name: DevKit.WebApi.StringValue;
		/** JSON object to pass key-value pairs for action buttons that are to be present on the notification */
		msdyn_NotificationButtons: DevKit.WebApi.StringValue;
		/** Deprecated field */
		msdyn_NotificationFieldsPlaceholder: DevKit.WebApi.StringValue;
		msdyn_RejectButtonAutoAccept: DevKit.WebApi.BooleanValue;
		/** Display label for the button to reject a notification */
		msdyn_RejectButtonText: DevKit.WebApi.StringValue;
		/** Notification display order relative to other notification templates. */
		msdyn_RenderingOrder: DevKit.WebApi.IntegerValue;
		/** Show countdown for when the notification will disappear */
		msdyn_Showtimeout: DevKit.WebApi.OptionSetValue;
		/** Theme color for Notification template. */
		msdyn_Theme: DevKit.WebApi.OptionSetValue;
		/** Notification time out period. */
		msdyn_Timeout: DevKit.WebApi.IntegerValue;
		/** The title to be displayed for this notification. */
		msdyn_Title: DevKit.WebApi.StringValue;
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
		/** Status of the Notification Template */
		statecode: DevKit.WebApi.OptionSetValue;
		/** Reason for the status of the Notification Template */
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
	namespace msdyn_consoleapplicationnotificationtemplate {
		enum msdyn_ActionButtons {
			/** 100000000 */
			Allow,
			/** 100000001 */
			Deny
		}
		enum msdyn_Showtimeout {
			/** 100000001 */
			No,
			/** 100000000 */
			Yes
		}
		enum msdyn_Theme {
			/** 100000000 */
			Dark,
			/** 100000001 */
			Light
		}
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