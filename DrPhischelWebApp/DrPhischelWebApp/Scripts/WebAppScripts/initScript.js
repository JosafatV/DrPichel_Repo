// Code goes here
angular.module('DrPhischelApp', ['ngRoute', 'ngResource']);




angular.module('DrPhischelApp').config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/Items', {
        templateUrl: 'portada.html',
        controller: 'portadaCdfontroller'
    })
      .otherwise({
          templateUrl: 'Vista_Doctor/VistaDoctor.html',
          controller: 'portadaController'
      })
}]);


