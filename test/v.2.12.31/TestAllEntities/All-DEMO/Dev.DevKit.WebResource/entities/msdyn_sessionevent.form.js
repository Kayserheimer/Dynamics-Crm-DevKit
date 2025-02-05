﻿'use strict';
/** @namespace DevKit */
var DevKit;
(function (DevKit) {
	'use strict';
	DevKit.FormSession_event_Form = function(executionContext, defaultWebResourceName) {
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
			msdyn_name: {},
			OwnerId: {}
		};
		devKit.LoadFields(formContext, body);
		var tab = {

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
	OptionSet.msdyn_sessionevent = {
		msdyn_eventinfo : {
			Default: 192350000
		},
		msdyn_eventreason : {
			Accepted: 192350019,
			AgentDisconnected: 192350010,
			AgentEndConversation: 192350030,
			AgentInviteRejected: 192350008,
			AgentInviteTimeout: 192350009,
			AgentTimeout: 192350011,
			AgentTransfer: 192350001,
			AgentTransferred: 192350012,
			AssignToAgentBySupervisor_: 192350026,
			AssignToQueueBySupervisor_: 192350027,
			AutoAccept: 192350006,
			AutoAccepted: 192350020,
			BotEndConversation_: 192350025,
			BotTransferSession_: 192350024,
			Closed: 192350007,
			CustomerDisconnect: 192350014,
			CustomerEndConversation: 192350029,
			CustomerRejoin: 192350028,
			CustomerTimeout: 192350013,
			Default: 192350000,
			Disconnect: 192350021,
			End: 192350023,
			Escalated: 192350016,
			PostchatSurvey: 192350004,
			PreChatSurvey: 192350003,
			QueueTransfer: 192350002,
			Rejected: 192350017,
			SessionTimeout: 192350015,
			TimedOut: 192350018,
			Timeout: 192350022,
			UserAccept: 192350005
		},
		msdyn_eventtype : {
			AgentAccepted: 192350003,
			AgentAssigned: 192350002,
			AgentDisconnected: 192350014,
			AgentEndConversation: 192350026,
			AgentInviteRejected: 192350004,
			AgentInviteTimeout: 192350007,
			AgentTimeout: 192350015,
			AssignToAgentBySupervisor: 192350023,
			AssignToQueueBySupervisor: 192350024,
			BotEndConversation: 192350022,
			BotTransferSession: 192350021,
			CustomerDisconnected: 192350017,
			CustomerEndConversation: 192350025,
			CustomerTimeout: 192350016,
			Default: 192350000,
			Escalated: 192350008,
			ParticipantEnd: 192350013,
			ParticipantInviteAccepted: 192350011,
			ParticipantInvited: 192350009,
			ParticipantInviteRejected: 192350010,
			ParticipantInviteTimeout: 192350012,
			ParticipantLeft: 192350020,
			QueueAssigned: 192350001,
			SessionCreated: 192350006,
			SessionEnd: 192350005,
			TransferedToAgent: 192350018,
			TransferedToQueue: 192350019
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