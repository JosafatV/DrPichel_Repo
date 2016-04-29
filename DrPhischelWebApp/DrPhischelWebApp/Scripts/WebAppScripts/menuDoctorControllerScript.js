
angular.module('DrPhischelApp').controller("menuDoctorController", ["$scope","$routeParams","$location",

function ($scope, $routeParams, $location) {
    
    $scope.goCrearPaciente = function () {
        $location.path('/DrPhischel/Doctor/crearPaciente');
    };

    $scope.goAgregarHistorial = function () {
        $location.path('/DrPhischel/Doctor/agregarHistorial');
    };

    $scope.goVerHistorial = function () {
        $location.path('/DrPhischel/Doctor/verHistorial');
    };

    $scope.prueba = function () {
        alert('Estan sirviendo')
    }
}]);
