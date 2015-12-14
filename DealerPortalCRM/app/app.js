(function () {

    angular.module("app", ["ui.router",'ngResource','xeditable',  'ui.grid', 'ui.grid.cellNav', 'ui.grid.edit', 'ui.grid.resizeColumns', 'ui.grid.pinning', 'ui.grid.selection', 'ui.grid.moveColumns', 'ui.grid.exporter', 'ui.grid.importer', 'ui.grid.grouping', 'ui.grid.pagination'])


        .controller("app", function ($scope) {
            $scope.myExternalScope = $scope;
        })
  .run(function (editableOptions) {
        editableOptions.theme = 'bs3';
    });

})();
