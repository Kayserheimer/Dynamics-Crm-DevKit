﻿'use strict';
/** @namespace DevKit */
var DevKit;
(function (DevKit) {
	'use strict';
	DevKit.FormKnowledge_Article = function(executionContext, defaultWebResourceName) {
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
			ArticlePublicNumber: {},
			Content: {},
			CreatedBy: {},
			CreatedOn: {},
			Description: {},
			ExpirationDate: {},
			Feedback: {},
			IsInternal: {},
			Keywords: {},
			KnowledgeArticleViews: {},
			KnowledgearticleviewsGrid: {},
			LanguageLocaleId: {},
			MajorVersionNumber: {},
			MinorVersionNumber: {},
			ModifiedBy: {},
			ModifiedOn: {},
			notescontrol: {},
			OwnerId: {},
			ParentArticleContentId: {},
			primaryauthorid: {},
			PublishOn: {},
			Rating: {},
			RelatedCategoriesGrid: {},
			RelatedTranslationsGrid: {},
			RootArticleId: {},
			StatusCode: {},
			SubjectId: {},
			Title: {}
		};
		devKit.LoadFields(formContext, body);
		var tab = {
			analytics: {
				Section: {
					Feedback: {},
					Views: {}
				}
			},
			general: {
				Section: {
					Content: {},
					Knowledge_Information: {}
				}
			},
			summary: {
				Section: {
					Portal_Settings: {},
					Publish_Settings: {},
					Timeline: {}
				}
			}
		};
		devKit.LoadTabs(formContext, tab);
		body.Tab = tab;
		form.Body = body;
		var header = {
			LanguageLocaleId: {},
			StatusCode: {}
		};
		devKit.LoadFields(formContext, header, "header_");
		form.Header = header;
		var footer = {
			MajorVersionNumber: {},
			MinorVersionNumber: {}
		};
		devKit.LoadFields(formContext, footer, "footer_");
		form.Footer = footer;
		var process = devKit.LoadProcess(formContext);
		var _New_Process = {
			ExpirationDate: {},
			Keywords: {},
			primaryauthorid: {},
			ReadyForReview: {},
			Review: {},
			SubjectId: {},
			UpdateContent: {}
		}
		devKit.LoadFields(formContext, _New_Process, "header_process_");
		process.New_Process = _New_Process;
		var _Translation_Process = {
			ExpirationDate: {},
			LanguageLocaleId: {}
		}
		devKit.LoadFields(formContext, _Translation_Process, "header_process_");
		process.Translation_Process = _Translation_Process;
		var _Expired_Process = {
			ExpirationDate: {},
			ExpirationDate_1: {},
			ExpiredReviewOptions: {},
			UpdateContent: {}
		}
		devKit.LoadFields(formContext, _Expired_Process, "header_process_");
		process.Expired_Process = _Expired_Process;
		form.Process = process;
		var quickForm = {
			relatedarticlequickform: {
			},
			relatedversionsquickform: {
			}
		};
		devKit.LoadQuickForms(formContext, quickForm);
		form.QuickForm = quickForm;
		var grid = {
			RelatedTranslationsGrid: {},
			RelatedCategoriesGrid: {},
			KnowledgearticleviewsGrid: {},
			Feedback: {},
		};
		devKit.LoadGrids(formContext, grid);
		form.Grid = grid;
		var navigation = {

		};
		devKit.LoadNavigations(formContext, navigation);
		form.Navigation = navigation;
		form.Utility = devKit.LoadUtility(defaultWebResourceName);
		form.ExecutionContext = devKit.LoadExecutionContext(executionContext);
		return form;
	};
	DevKit.FormKnowledge_Article_for_Interactive_experience = function(executionContext, defaultWebResourceName) {
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
			ArticlePublicNumber: {},
			Content: {},
			CreatedBy: {},
			CreatedOn: {},
			Description: {},
			ExpirationDate: {},
			Feedback: {},
			IsInternal: {},
			Keywords: {},
			KnowledgeArticleViews: {},
			KnowledgearticleviewsGrid: {},
			LanguageLocaleId: {},
			MajorVersionNumber: {},
			MinorVersionNumber: {},
			ModifiedBy: {},
			ModifiedOn: {},
			notescontrol: {},
			OwnerId: {},
			ParentArticleContentId: {},
			primaryauthorid: {},
			PublishOn: {},
			Rating: {},
			RelatedCategoriesGrid: {},
			RelatedTranslationsGrid: {},
			RootArticleId: {},
			StatusCode: {},
			SubjectId: {},
			Title: {}
		};
		devKit.LoadFields(formContext, body);
		var tab = {
			analytics: {
				Section: {
					Feedback: {},
					Views: {}
				}
			},
			general: {
				Section: {
					Content: {},
					Knowledge_Information: {}
				}
			},
			summary: {
				Section: {
					Portal_Settings: {},
					Publish_Settings: {},
					Timeline: {}
				}
			}
		};
		devKit.LoadTabs(formContext, tab);
		body.Tab = tab;
		form.Body = body;
		var header = {
			LanguageLocaleId: {},
			StatusCode: {}
		};
		devKit.LoadFields(formContext, header, "header_");
		form.Header = header;
		var footer = {
			MajorVersionNumber: {},
			MinorVersionNumber: {}
		};
		devKit.LoadFields(formContext, footer, "footer_");
		form.Footer = footer;
		var process = devKit.LoadProcess(formContext);
		var _New_Process = {
			ExpirationDate: {},
			Keywords: {},
			primaryauthorid: {},
			ReadyForReview: {},
			Review: {},
			SubjectId: {},
			UpdateContent: {}
		}
		devKit.LoadFields(formContext, _New_Process, "header_process_");
		process.New_Process = _New_Process;
		var _Translation_Process = {
			ExpirationDate: {},
			LanguageLocaleId: {}
		}
		devKit.LoadFields(formContext, _Translation_Process, "header_process_");
		process.Translation_Process = _Translation_Process;
		var _Expired_Process = {
			ExpirationDate: {},
			ExpirationDate_1: {},
			ExpiredReviewOptions: {},
			UpdateContent: {}
		}
		devKit.LoadFields(formContext, _Expired_Process, "header_process_");
		process.Expired_Process = _Expired_Process;
		form.Process = process;
		var quickForm = {
			relatedarticlequickform: {
			},
			relatedversionsquickform: {
			}
		};
		devKit.LoadQuickForms(formContext, quickForm);
		form.QuickForm = quickForm;
		var grid = {
			RelatedTranslationsGrid: {},
			RelatedCategoriesGrid: {},
			KnowledgearticleviewsGrid: {},
			Feedback: {},
		};
		devKit.LoadGrids(formContext, grid);
		form.Grid = grid;
		var navigation = {

		};
		devKit.LoadNavigations(formContext, navigation);
		form.Navigation = navigation;
		form.Utility = devKit.LoadUtility(defaultWebResourceName);
		form.ExecutionContext = devKit.LoadExecutionContext(executionContext);
		return form;
	};
	DevKit.FormKnowledge_Article_Quick_Create = function(executionContext, defaultWebResourceName) {
		var formContext = null;
		if (executionContext !== undefined)
		{
			if (executionContext.getFormContext === undefined) {
				formContext = executionContext;
			}
			else {
				formContext = executionContext.getFormContext();
			}
		}
		var form = devKit.LoadForm(formContext);
		var body = {
			Description: {},
			Keywords: {},
			LanguageLocaleId: {},
			OwnerId: {},
			primaryauthorid: {},
			Title: {}
		}
		devKit.LoadFields(formContext, body);
		var tab = {
			newKnowledgeArticle: {
				Section: {
					quickKnowledgeArticle: {},
					quickKnowledgecontent: {},
					quickKnowledgeowner: {}
				}
			}
		}
		devKit.LoadTabs(formContext, tab);
		body.Tab = tab;
		form.Body = body;
		form.Utility = devKit.LoadUtility(defaultWebResourceName);
		return form;
	}
})(DevKit || (DevKit = {}));
/** @namespace OptionSet */
var OptionSet;
(function (OptionSet) {
	OptionSet.KnowledgeArticle = {
		ExpiredReviewOptions : {
			Archive: 2,
			Needs_Updating: 0,
			Republish: 1
		},
		Review : {
			Approved: 0,
			Rejected: 1
		},
		StateCode : {
			Approved: 1,
			Archived: 5,
			Discarded: 6,
			Draft: 0,
			Expired: 4,
			Published: 3,
			Scheduled: 2
		},
		StatusCode : {
			Approved: 5,
			Archived: 12,
			Discarded: 13,
			Draft: 2,
			Expired: 10,
			In_review: 4,
			Needs_review_3: 3,
			Needs_review_8: 8,
			Proposed: 1,
			Published: 7,
			Rejected_11: 11,
			Rejected_14: 14,
			Scheduled: 6,
			Updating: 9
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