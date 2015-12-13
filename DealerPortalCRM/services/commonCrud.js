
(function () {

    angular.module("app").factory("commonCrud", [
            "$http", function ($http) {

                var factory = {};

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

               

                return factory;
            }
    ]);

})();