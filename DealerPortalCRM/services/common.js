
(function () {

    angular.module("app").factory("common", [
            "$http", function ($http) {

                var factory = {};

                //get all list on load
                factory.getAllVehicleMakeModelClass = function (model) {

                    model = { slip: "2", take: "2" };
                    return $http.get("/GetAllVehicleMakeModelClassViewModelAsync/", {
                        params: { skip: "2", take: "2" }
                    })
                      .success(function (data, status, headers, config) {

                          return data;
                      })
                      .error(function (data, status, headers, config) {
                          console.log(data);
                          console.log(status);
                          return data;
                      });
                };

                //get model by id
                factory.getModelTypeByID = function (id) {


                    return $http.get("/GetVehicleModelTypeByVehicleMakeTypeID/", {
                        params: { id: parseInt(id) }
                    }
                    )
                      .success(function (data, status, headers, config) {

                          return data;
                      })
                      .error(function (data, status, headers, config) {
                          console.log(data);
                          console.log(status);
                          return data;
                      });
                };

                factory.update = function (model) {

                    return $http.put("api/VehicleMakeModel/", model
                    )
                      .success(function (data, status, headers, config) {

                          return data;
                      })
                      .error(function (data, status, headers, config) {
                          console.log(data);
                          console.log(status);
                          return data;
                      });
                };

                factory.delete = function (model) {

                    return $http.put("api/VehicleMakeModel/", model
                    )
                      .success(function (data, status, headers, config) {

                          return data;
                      })
                      .error(function (data, status, headers, config) {
                          console.log(data);
                          console.log(status);
                          return data;
                      });
                };


                factory.add = function (model) {

                    return $http.put("api/VehicleMakeModel/", model
                    )
                      .success(function (data, status, headers, config) {

                          return data;
                      })
                      .error(function (data, status, headers, config) {
                          console.log(data);
                          console.log(status);
                          return data;
                      });
                };





                return factory;
            }
    ]);

})();