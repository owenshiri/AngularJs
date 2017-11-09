angular.module('app').factory('employeeService',
    ['$http', 'ngServiceSettings',
        function ($http, ngServiceSettings) {
            var employeeService = {};
            var serviceBase = ngServiceSettings.apiServiceBaseUri + 'api/Employee/';
            
            employeeService.getEmployee = function () {
                return $http.get(serviceBase + 'GetEmployee').then(function (results) {
                    return results;
                });
            };
            employeeService.saveEmployee = function (employee) {
                return $http.post(serviceBase + 'SaveEmployee', JSON.stringify(employee)).then(function (results) {
                    return results;
                });
            };
            return employeeService;
        }]);