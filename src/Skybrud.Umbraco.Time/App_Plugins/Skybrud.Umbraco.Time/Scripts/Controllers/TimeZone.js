angular.module("umbraco").controller("Skybrud.TimeZone.Controller", function ($scope, $http) {

    const vm = this;

    vm.loading = true;
    vm.timeZone = null;
    vm.timeZones = null;

    vm.change = function () {
        $scope.model.value = vm.timeZone.id;
    };

    $http.get("/umbraco/backoffice/Skybrud/Time/GetTimeZones").then(function (res) {

        vm.loading = false;
        vm.timeZones = res.data;

        if ($scope.model.value) {
            vm.timeZones.forEach(function(tz) {
                if (tz.id === $scope.model.value) {
                    vm.timeZone = tz;
                }
            });
        }

        if (!vm.timeZone) {
            vm.timeZone = vm.timeZones.find(x => x.id === "local");
            $scope.model.value = "local";
        }

    });

});