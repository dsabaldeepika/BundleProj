
(function () {

    angular.module("app").controller("vehicleMakeModelClass", [
        "$scope", "uiGridConstants", "uiGridGroupingConstants", "commonCrud","restService",
        function ($scope, uiGridConstants, uiGridGroupingConstants, commonCrud, restService) {

            restService.baseurl = "api/VehicleMakeModel/"

            $scope.model = { VehicleMakeModelClassId: 2, VehicleMakeModelClassName :"sabal" };

            $scope.add = function () {

                restService.add($scope.model).then(function (result) {
                    $scope.gridOptions.data = result.data;

                });
            }


                restService.get().then(function (result) {
                    $scope.gridOptions.data = result.data;

                });
            
            $scope.update = function () {
                restService.update($scope.model).then(function (result) {
                    $scope.gridOptions.data = result.data;

                });
            }

            $scope.delete = function () {

                restService.delete(2).then(function (result) {
                   
                });
            }
          
           

        

        }
    ]);

})();