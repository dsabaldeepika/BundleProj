
(function() {

    angular.module("app").controller("adjustment", [
        "$scope", "uiGridConstants", "uiGridGroupingConstants", "commonCrud", "restService","$filter",
        function ($scope, uiGridConstants, uiGridGroupingConstants, commonCrud, restService, $filter) {

            restService.baseurl = "api/adjustment/";

           
            restService.update($scope.currentlyEdited).then(function (result) {
                 console.log(result);
            });

            $scope.users = [
              restService.get().then(function(result) {
                $scope.user = result.data;
            })
            ]; 

            $scope.statuses = [
              {value: 1, text: 'status1'},
              {value: 2, text: 'status2'},
              {value: 3, text: 'status3'},
              {value: 4, text: 'status4'}
            ]; 


            $scope.groups = [];
            $scope.loadGroups = function() {
                return $scope.groups.length ? null : $http.get('/groups').success(function(data) {
                    $scope.groups = data;
                });
            };

            $scope.showGroup = function(user) {
                if(user.group && $scope.groups.length) {
                    var selected = $filter('filter')($scope.groups, {id: user.group});
                    return selected.length ? selected[0].text : 'Not set';
                } else {
                    return user.groupName || 'Not set';
                }
            };

            $scope.showStatus = function(user) {
                var selected = [];
                if(user.status) {
                    selected = $filter('filter')($scope.statuses, {value: user.status});
                }
                return selected.length ? selected[0].text : 'Not set';
            };

            // remove user
            $scope.removeUser = function(index) {
                $scope.users.splice(index, 1);
                restService.delete(index).then(function (result) {
                    });
            };

            // add user
            $scope.addUser = function() {
                $scope.users.push($scope.inserted);
                restService.add($scope.newUser).then(function (result) {
                    console.log(result);
                });
            };
    
                 
        
        }
    ]);

})();