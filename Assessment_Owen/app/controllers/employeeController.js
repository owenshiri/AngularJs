angular.module('app').controller('employeeCtrl', [
    '$scope', 'employeeService', function ($scope, employeeService) {

        employeeService.getEmployee().then(function (resp) {
            $scope.employee = resp.data;
        }, function (err) {
            alert('an error occurred while loadin employee data')
        });
        $scope.saveEmployee = function () {
            employeeService.saveEmployee($scope.employee).then(function (resp) {
                alert('employee saved');
            }, function (err) {
                alert('an error occurred while adding employee');
            });
        }
    }]);