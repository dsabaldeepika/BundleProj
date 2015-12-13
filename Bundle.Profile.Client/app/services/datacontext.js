(function () {
    'use strict';

    var serviceId = 'datacontext';
    angular.module('app').factory(serviceId, ['common', function datacontext(common ) {

        var $http = common.$http;

        var service = {
            getPeople: getPeople,
            getMessageCount: getMessageCount
        };

        return service;

        function getMessageCount() {
         return $http({
                method: 'GET',
                url: '/someUrl'
            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
            }, function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
        }

        function getPeople() {
            return $http({
                method: 'GET',
                url: '/someUrl'
            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
            }, function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
             
        }
    }]);

})();