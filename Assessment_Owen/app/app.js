angular.module('app', ['ui.router', 'ui.bootstrap']);

angular.module('app').constant('ngServiceSettings', {
    apiServiceBaseUri: 'http://localhost:64808/'
});

angular.module('app').config(['$stateProvider', function ($stateProvider) {
    $stateProvider
        //employee
        .state('employee',
        {
            url: '/',
            templateUrl: '../app/views/employee.html',
            controller: 'employeeCtrl'
        })
}]);

angular.module('app').config(['$compileProvider', function ($compileProvider) {
    $compileProvider.debugInfoEnabled(false);
}]);

angular.module('app').config(['$httpProvider', function ($httpProvider) {
    $httpProvider.defaults.withCredentials = true;
    $httpProvider.defaults.headers.post['Content-Type'] = 'application/x-www-form-urlencoded';
}]);
angular.module('app').config(['$locationProvider', function ($locationProvider) {
    $locationProvider.hashPrefix('');
}]);