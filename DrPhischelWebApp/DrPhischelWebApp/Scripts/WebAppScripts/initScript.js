// Code goes here
angular.module('DrPhischelApp', ['ngRoute', 'ngResource']);




angular.module('DrPhischelApp').config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/Items', {
        templateUrl: 'portada.html',
        controller: 'portadaCdfontroller'
    })
      .otherwise({
          templateUrl: 'Menu/menu.html',
          controller: 'portadaController'
      })
}]);


