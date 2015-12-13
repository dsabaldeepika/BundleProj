(function () {
  angular.module("app")
        .config(["$stateProvider", "$urlRouterProvider", function ($stateProvider, $urlRouterProvider) {
            
            $urlRouterProvider.otherwise('/VehicleMakeModel');
            $stateProvider
                .state("Adjustment", {
                    url: "/Adjustment",
                    templateUrl: "app/Adjustment/Adjustment.html",
                    controller: "adjustment"
                })
             .state("VehicleMakeModel", {
                 url: "/VehicleMakeModel",
                 templateUrl: "/app/VehicleMakeModelClass/VehicleMakeModelClass.html",
                 controller: "vehicleMakeModelClass"
             })
            
            .state("AdjustmentRange", {
                url: "/AdjustmentRange",
                templateUrl: "app/AdjustmentRange/adjustmentRange.html",
                controller: "adjustmentRange"
            })
            .state("AdjustmentType", {
                url: "/AdjustmentType",
                templateUrl: "app/VehicleMakeModel/AdjustmentType.html",
                controller: "adjustmentType"
            })
            .state("BuyRate", {
                url: "/BuyRate",
                templateUrl: "app/BuyRate/BuyRate.html",
                controller: "buyRate"
            })
            .state("ClassCodeAdj", {
                url: "/ClassCodeAdj",
                templateUrl: "app/ClassCodeAdj/ClassCodeAdj.html",
                controller: "classCodeAdj"
            })
            .state("DealerDiscount", {
                url: "/DealerDiscount",
                templateUrl: "app/DealerDiscount/DealerDiscount.html",
                controller: "dealerDiscount"
            })
            .state("DocFee", {
                url: "/DocFee",
                templateUrl: "app/DocFee/DocFee.html",
                controller: "docFee"
            })
            .state("DealerScore", {
                url: "/DealerScore",
                templateUrl: "app/DealerScore/DealerScore.html",
                controller: "dealerScore"
            })
            .state("ExcessMileage", {
                url: "/ExcessMileage",
                templateUrl: "app/ExcessMileage/ExcessMileage.html",
                controller: "excessMileage"
            })
            .state("PricingBase", {
                url: "/PricingBase",
                templateUrl: "app/PricingBase/PricingBase.html",
                controller: "pricingBase"
            })
            .state("ScoringEngineResults", {
                url: "/ScoringEngineResults",
                templateUrl: "app/ScoringEngineResults/ScoringEngineResults.html",
                controller: "scoringEngineResults"
            })
            .state("StateAdjustment", {
                url: "/StateAdjustment",
                templateUrl: "app/StateAdjustment/StateAdjustment.html",
                controller: "stateAdjustment"
            })
            .state("StateFicoRange", {
                url: "/StateFicoRange",
                templateUrl: "app/StateFicoRange/StateFicoRange.html",
                controller: "vehicleMakeModel"
            })
            .state("TermCap", {
                url: "/StateCode",
                templateUrl: "app/TermCap/TermCap.html",
                controller: "termCap"
            })
            .state("VehicleClassType", {
                url: "/VehicleClassType",
                templateUrl: "app/VehicleClassType/VehicleClassType.html",
                controller: "vehicleClassType"
            })
            .state("VehicleModelType", {
                url: "/VehicleModelType",
                templateUrl: "app/VehicleModelType/VehicleModelType.html",
                controller: "vehicleModelType"
            })
            .state("WhatIfAnalysis", {
                url: "/WhatIfAnalysis",
                templateUrl: "app/WhatIfAnalysis/whatIfAnalysis.html",
                controller: "whatIfAnalysis"
            });
        }]);
})();












