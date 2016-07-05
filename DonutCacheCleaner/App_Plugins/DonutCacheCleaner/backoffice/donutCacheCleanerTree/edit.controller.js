angular.module("umbraco").controller("OA.CacheCleanerEditController",
	function ($scope, $routeParams, cachecleanerResource, notificationsService, navigationService, userService) {

	    $scope.loaded = true;

	    $scope.node = {};  

	    $scope.clearcache = function () {
	        cachecleanerResource.clearCache().then(function (response) {
	            notificationsService.success("Success", "Cache has been cleared");
	        });
	    };
	});