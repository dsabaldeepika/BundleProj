
(function() {

    angular.module("app").factory("restService", [
        "$http", function($http) {

            var factory = {};
            factory.baseurl=""

            console.log(factory.baseurl);
            factory.get = function() {
                return $http.get(factory.baseurl)
                    .success(function(data, status, headers, config) {
                        return data;
                    })
                    .error(function(data, status, headers, config) {
                        console.log(data);
                        console.log(status);
                        return data;
                    });
            };
            factory.update = function(model) {

                return $http.put(factory.baseurl, JSON.stringify(model)
                    )
                    .success(function(data, status, headers, config) {

                        return data;
                    })
                    .error(function(data, status, headers, config) {
                        console.log(data);
                        console.log(status);
                        return data;
                    });
            };
            factory.delete = function(model) {

                return $http.put(factory.baseurl, JSON.stringify(model)
                    )
                    .success(function(data, status, headers, config) {

                        return data;
                    })
                    .error(function(data, status, headers, config) {
                        console.log(data);
                        console.log(status);
                        return data;
                    });
            };
            factory.add = function(model) {

                return $http.put(factory.baseurl, JSON.stringify(model)
                    )
                    .success(function(data, status, headers, config) {

                        return data;
                    })
                    .error(function(data, status, headers, config) {
                        console.log(data);
                        console.log(status);
                        return data;
                    });
            };
            return factory;
        }
    ]);
})();