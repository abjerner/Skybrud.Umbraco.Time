angular.module("umbraco").controller("Limbo.Umbraco.TimePicker.Controller", function ($scope, $element, $timeout) {

    if (!$scope.model.value) $scope.model.value = "";

    $scope.hour = "";
    $scope.minute = "";

    $scope.id = "limbo" + Math.random().toString().replace(".", "");

    var hour = $element[0].querySelector(".hour");
    var minute = $element[0].querySelector(".minute");

    console.log(hour);
    console.log(minute);

    var m1 = $scope.model.value.match(/^([0-9]{1,2}):([0-9]{1,2})$/);
    var m2 = $scope.model.value.match(/^([0-9]{1,2}):([0-9]{1,2}):([0-9]{1,2})$/);

    if (m1) {
        $scope.hour = parseInt(m1[1]);
        $scope.minute = parseInt(m1[2]);
    } else if (m2) {
        $scope.hour = parseInt(m2[1]);
        $scope.minute = parseInt(m2[2]);
    }

    $scope.add = function() {

        $scope.model.value = "00:00";
        $scope.hour = 0;
        $scope.minute = 0;

        $timeout(function() {
            hour.focus();
        }, 20);

    };

    $scope.clear = function() {
        $scope.model.value = "";
        $scope.hour = "";
        $scope.minute = "";
    };

    $scope.update = function () {

        $scope.hour = Math.max(0, Math.min(23, parseInt(hour.value) || 0));
        $scope.minute = Math.max(0, Math.min(59, parseInt(minute.value) || 0));

        var h = $scope.hour < 10 ? `0${$scope.hour}` : "" + $scope.hour;
        var m = $scope.minute < 10 ? `0${$scope.minute}` : `${$scope.minute}`;

        $scope.model.value = h + ":" + m;

    };

});