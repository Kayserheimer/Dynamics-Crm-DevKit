﻿'use strict';
/** @namespace DevKit */
var DevKit;
(function (DevKit) {
	'use strict';
	DevKit.FormSearch_provider_Main_form = function(executionContext, defaultWebResourceName) {
		var formContext = null;
		if (executionContext !== undefined) {
			if (executionContext.getFormContext === undefined) {
				formContext = executionContext;
			}
			else {
				formContext = executionContext.getFormContext();
			}
		}
		var form = devKit.LoadForm(formContext);
		var body = {
			ConnectionId: {},
			msdyn_Description: {},
			msdyn_Name: {},
			Organization: {},
			OwnerId: {},
			SearchType: {},
			SharepointURL: {},
			WebResource_Disclaimer: {}
		};
		devKit.LoadFields(formContext, body);
		var tab = {
			_AB87433A_5CC0_4BCF_B306_F697B6B56F37: {
				Section: {
					_2D5C8850_749F_4FCA_807A_E58949695F92: {},
					_AB87433A_5CC0_4BCF_B306_F697B6B56F37_SECTION_3: {}
				}
			}
		};
		devKit.LoadTabs(formContext, tab);
		body.Tab = tab;
		form.Body = body;
		var quickForm = {

		};
		devKit.LoadQuickForms(formContext, quickForm);
		form.QuickForm = quickForm;
		var navigation = {

		};
		devKit.LoadNavigations(formContext, navigation);
		form.Navigation = navigation;
		form.Utility = devKit.LoadUtility(defaultWebResourceName);
		form.ExecutionContext = devKit.LoadExecutionContext(executionContext);
		return form;
	};
})(DevKit || (DevKit = {}));
/** @namespace OptionSet */
var OptionSet;
(function (OptionSet) {
	OptionSet.msdyn_kmfederatedsearchconfig = {
		SearchType : {
			Cross_Organizational_Search: 100000000,
			Microsoft_Search_Connector: 100000002,
			Sharepoint: 100000001
		},
		statecode : {
			Active: 0,
			Inactive: 1
		},
		statuscode : {
			Active: 1,
			Inactive: 2
		},
        RollupState : {
            NotCalculated: 0,
            Calculated: 1,
            OverflowError: 2,
            OtherError: 3,
            RetryLimitExceeded: 4,
            HierarchicalRecursionLimitReached: 5,
            LoopDetected: 6
        }

	};
})(OptionSet || (OptionSet = {}));