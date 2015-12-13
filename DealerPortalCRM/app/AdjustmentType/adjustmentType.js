
(function () {

    angular.module("app").controller("adjustmentType", [
        "$scope", "uiGridConstants", "uiGridGroupingConstants", "commonCrud",
        function ($scope, uiGridConstants, uiGridGroupingConstants, commonCrud) {

            commonCrud.getAllVehicleMakeModelClass().then(function (result) {
                $scope.gridOptions.data = result.data;

            });

            //$scope.gridOptions.rowIdentity = function (row) {
            //    return row.id;
            //};
            //$scope.gridOptions.getRowIdentity = function (row) {
            //    return row.id;
            //};

            $scope.gridOptions = {
                columnDefs: [
                    { field: "VehicleMakeTypeDisplayName", cellTooltip: "Click to edit", enableCellEditOnFocus: true },
                    {
                        name: "VehicleModelTypeDisplayName", field: "VehicleModelTypeDisplayName", editType: "dropdown", enableCellEdit: true, editDropdownOptionsArray: $scope.VehicleModelTypeDisplayName, editableCellTemplate: "ui-grid/dropdownEditor", editDropdownIdLabel: "VehicleModelTypeDisplayName"
                    },
                    { field: "VehicleClassTypeDisplayName", enableCellEdit: true },
                    { field: "VehicleMakeModelClassCreatedDate", enableCellEdit: true },
                    { field: "VehicleMakeModelClassModifiedDate", enableCellEdit: true }
                ],

                enableGridMenu: true,
                enableFiltering: true,
                showColumnFooter: true,
                enableColumnResizing: true,
                showGridFooter: true,
                enableSorting: true,
                enablePaginationControls: false,
                paginationPageSize: 25


            };

            $scope.currentFocused = "";

            $scope.gridOptions.onRegisterApi = function (gridApi) {

                //set gridApi on scope
                $scope.gridApi = gridApi;
                gridApi.edit.on.afterCellEdit($scope, function (rowEntity, colDef) {

                    commonCrud.getModelTypeByID(rowEntity.VehicleMakeTypeID).then(function (result) {


                        //   $scope.VehicleModelTypeDisplayName = result.data;

                        angular.forEach(result.data, function (key, value) {
                            $scope.VehicleModelTypeDisplayName.push({ "id": key, "key": value });

                        });

                        console.log($scope.VehicleModelTypeDisplayName);
                        //    rowEntity.VehicleModelTypeDisplayName = $scope.VehicleModelTypeDisplayName;
                    });

                });

                //gridApi.edit.on.afterCellEdit($scope, function (rowEntity, colDef, newValue, oldValue) {
                //    if (colDef.name === 'gender') {
                //        if (newValue === 1) {
                //            rowEntity.sizeOptions = $scope.maleSizeDropdownOptions;
                //        } else {
                //            rowEntity.sizeOptions = $scope.femaleSizeDropdownOptions;
                //        }
                //    }
                //});
            };
            $scope.gridOptions.importerDataAddCallback = function (grid, newObjects) {
                $scope.data = $scope.data.concat(newObjects);
            };

            console.log($scope.gridOptions);
            console.log($scope.gridOptions.columnDefs);

            $scope.update = function () {
                var rowCol = $scope.gridApi.cellNav.getFocusedCell();

                if (rowCol !== null) {
                    $scope.currentlyEdited = rowCol.row.entity;

                    //commonCrud.update($scope.currentlyEdited).then(function (result) {
                    //     $scope.gridOptions.data = result.data;
                    //    console.log(result);
                    //});
                }
            };
        }
    ]);

})();