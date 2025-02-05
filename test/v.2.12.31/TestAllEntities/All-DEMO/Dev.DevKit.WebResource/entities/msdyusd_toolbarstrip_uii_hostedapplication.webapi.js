﻿'use strict';
/** @namespace DevKit */
var DevKit;
(function (DevKit) {
	'use strict';
	DevKit.msdyusd_toolbarstrip_uii_hostedapplicationApi = function (e) {
		var EMPTY_STRING = '';
		var f = '@OData.Community.Display.V1.FormattedValue';
        function webApiField(entity, logicalName, schemaName, entityLogicalCollectionName, entityLogicalName, readOnly, upsertEntity, isMultiOptionSet) {
            var l = '@Microsoft.Dynamics.CRM.lookuplogicalname';
            var property = {};
            var getFormattedValue = function () {
                if (entity[logicalName + f] === undefined || entity[logicalName + f] === null) {
                    return EMPTY_STRING;
                }
                if (entityLogicalCollectionName !== undefined && entityLogicalCollectionName.length > 0) {
                    if (entity[logicalName + l] === entityLogicalName) {
                        return entity[logicalName + f];
                    }
                    return EMPTY_STRING;
                }
                if (isMultiOptionSet) {
                    return entity[logicalName + f].toString().split(';').map(function (item) { return item.trim(); });
                }
                return entity[logicalName + f];
            };
            var getValue = function () {
                if (entity[logicalName] === undefined || entity[logicalName] === null) {
                    return null;
                }
                if (entityLogicalCollectionName !== undefined && entityLogicalCollectionName.length > 0) {
                    if (entity[logicalName + l] === undefined || entity[logicalName + l] === entityLogicalName) {
                        return entity[logicalName];
                    }
                    return null;
                }
                if (isMultiOptionSet) {
                    return entity[logicalName].toString().split(',').map(function (item) { return parseInt(item, 10); });
                }
                return entity[logicalName];
            };
            var setValue = function (value) {
                if (isMultiOptionSet) value = value.join(',');
                if (entityLogicalCollectionName !== undefined && entityLogicalCollectionName.length > 0) {
                    value = value.replace('{', EMPTY_STRING).replace('}', EMPTY_STRING);
                    upsertEntity[schemaName + '@odata.bind'] = '/' + entityLogicalCollectionName + '(' + value + ')';
                } else {
                    upsertEntity[logicalName] = value;
                }
                entity[logicalName] = value;
            };
            Object.defineProperty(property, 'FormattedValue', {
                get: getFormattedValue
            });
            if (readOnly) {
                Object.defineProperty(property, 'Value', {
                    get: getValue
                });
            }
            else {
                Object.defineProperty(property, 'Value', {
                    get: getValue,
                    set: setValue
                });
            }
            return property;
        }
		var msdyusd_toolbarstrip_uii_hostedapplication = {
			msdyusd_toolbarstrip_uii_hostedapplicationId: { a: 'msdyusd_toolbarstrip_uii_hostedapplicationid', r: true },
			msdyusd_toolbarstripid: { a: 'msdyusd_toolbarstripid', r: true },
			uii_hostedapplicationid: { a: 'uii_hostedapplicationid', r: true },
			VersionNumber: { a: 'versionnumber', r: true }
		};
		if (e === undefined) e = {};
		var u = {};
		for (var field in msdyusd_toolbarstrip_uii_hostedapplication) {
			var a = msdyusd_toolbarstrip_uii_hostedapplication[field].a;
			var b = msdyusd_toolbarstrip_uii_hostedapplication[field].b;
			var c = msdyusd_toolbarstrip_uii_hostedapplication[field].c;
			var d = msdyusd_toolbarstrip_uii_hostedapplication[field].d;
			var g = msdyusd_toolbarstrip_uii_hostedapplication[field].g;
			var r = msdyusd_toolbarstrip_uii_hostedapplication[field].r;
			msdyusd_toolbarstrip_uii_hostedapplication[field] = webApiField(e, a, b, c, d, r, u, g);
		}
		msdyusd_toolbarstrip_uii_hostedapplication.Entity = u;
		msdyusd_toolbarstrip_uii_hostedapplication.EntityName = 'msdyusd_toolbarstrip_uii_hostedapplication';
		msdyusd_toolbarstrip_uii_hostedapplication.EntityCollectionName = '';
		msdyusd_toolbarstrip_uii_hostedapplication['@odata.etag'] = e['@odata.etag'];
		msdyusd_toolbarstrip_uii_hostedapplication.getAliasedValue = function (alias, isMultiOptionSet) {
			if (e[alias] === undefined || e[alias] === null) {
				return null;
			}
			if (isMultiOptionSet) {
				return e[alias].toString().split(',').map(function (item) { return parseInt(item, 10); });
			}
			return e[alias];
		}
		msdyusd_toolbarstrip_uii_hostedapplication.getAliasedFormattedValue = function (alias, isMultiOptionSet) {
			if (e[alias + f] === undefined || e[alias + f] === null) {
				return EMPTY_STRING;
			}
			if (isMultiOptionSet) {
				return e[alias + f].toString().split(';').map(function (item) { return item.trim(); });
			}
			return e[alias + f];
		}
		return msdyusd_toolbarstrip_uii_hostedapplication;
	};
})(DevKit || (DevKit = {}));
/** @namespace OptionSet */
var OptionSet;
(function (OptionSet) {
	OptionSet.msdyusd_toolbarstrip_uii_hostedapplication = {
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