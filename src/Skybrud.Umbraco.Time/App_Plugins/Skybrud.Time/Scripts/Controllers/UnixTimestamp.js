angular.module("umbraco").controller("Skybrud.UnixTimestamp.Controller", function ($scope) {

    var vm = this;

    $scope.model.readonly = $scope.model.config.readonly === true;

    vm.config = {
        inline: false,
        enableTime: true,
        dateFormat: "Y-m-d H:i:ss",
        momentFormat: "YYYY-MM-DD HH:mm:ss",
        time_24hr: true
    };

    vm.date = null;
    vm.value = null;

    vm.datePickerChange = function (selectedDates, dateStr) {
        vm.value = dateStr;
        vm.rawValue = dateStr;
        vm.date = selectedDates.length > 0 ? selectedDates[0] : null;
        update();
    };

    vm.clearDate = function () {
        vm.value = null;
        vm.rawValue = null;
        vm.date = null;
        update();
    };

    vm.inputChanged = function () {

        if (vm.rawValue === "") {

            vm.clearDate();

        } else if (vm.rawValue) {

            let momentDate = moment(vm.rawValue, vm.config.momentFormat, true);

            if (!momentDate || !momentDate.isValid()) {
                momentDate = moment(new Date(vm.rawValue));
            }

            if (momentDate && momentDate.isValid()) {

                console.log(momentDate);

                vm.date = momentDate.toDate();
                vm.value = vm.rawValue = momentDate.format(vm.config.momentFormat);

                update();

            }

        }

    };

    function update() {

        if (!vm.value) {
            $scope.model.value = null;
            return;
        }

        // Convert to UNIX time
        $scope.model.value = vm.date ? parseInt(vm.date.getTime() / 1000) : null;

    }

    function init() {

        // Convert from UNIX time
        if ($scope.model.value !== "") {
            vm.date = new Date($scope.model.value * 1000);
            vm.value = vm.rawValue = moment(vm.date).format(vm.config.momentFormat);
        }

    }

    init();

});