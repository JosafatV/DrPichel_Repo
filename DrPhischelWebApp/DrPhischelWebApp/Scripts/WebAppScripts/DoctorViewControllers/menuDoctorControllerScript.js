//This controller is used to controll the menu of the doctors
var docActual = 6;
angular.module('DrPhischelApp').controller("menuDoctorController", ["$scope", "$routeParams",
    "$location", "drPhischelApiResource", function ($scope, $routeParams, $location, drPhischelApiResource) {

    //Changed the view to the createPatient
    $scope.goCrearPaciente = function () {
        $location.path('/DrPhischel/Doctor/CrearPaciente');        
    };

    //Changed the view to Agregate historial
    $scope.goAgregarHistorial = function () {
        $location.path('/DrPhischel/Doctor/AgregarHistorialTabla');
    };

    $scope.goAgregarPedido = function () {
        $location.path('/DrPhischel/Doctor/AgregarPedido');
    };

    //Changed the view to the historial view
    $scope.goVerHistorial = function () {
        $location.path('/DrPhischel/Doctor/VerHistorial');
    };
    //Changed the view to the calendario view
    $scope.goVerCalendario = function () {
        $location.path('/DrPhischel/Doctor/calendarioDeCitas');
    };
}]);
