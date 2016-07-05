angular.module("umbraco.resources")
	.factory("cachecleanerResource", function ($http) {

	    return {
	        clearCache: function () {
	            return $http.get("backoffice/DonutCacheCleaner/DonutCacheCleanerApi/ClearCache");
	        }
	    };
	});