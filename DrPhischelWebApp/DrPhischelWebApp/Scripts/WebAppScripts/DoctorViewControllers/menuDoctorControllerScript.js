//This controller is used to controll the menu of the doctors
angular.module('DrPhischelApp').controller("menuDoctorController", ["$scope", "$routeParams",
    "$location", "drPhischelApiResource", function ($scope, $routeParams, $location, drPhischelApiResource) {

    //Changed the view to the createPatient
    $scope.goCrearPaciente = function () {
        $location.path('/DrPhischel/Doctor/CrearPaciente');        
    };

    //Changed the view to Agregate historial
    $scope.goAgregarHistorial = function () {
        $location.path('/DrPhischel/Doctor/AgregarHistorial');
    };

    //Changed the view to the historial view
    $scope.goVerHistorial = function () {
        $location.path('/DrPhischel/Doctor/VerHistorial');
    };
}]);
