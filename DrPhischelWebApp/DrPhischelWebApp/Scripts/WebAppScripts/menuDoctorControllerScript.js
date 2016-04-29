//This controller is used to controll the menu of the doctors
angular.module('DrPhischelApp').controller("menuDoctorController", ["$scope","$routeParams","$location",
function ($scope, $routeParams, $location) {

    //Changed the view to the createPatient
    $scope.goCrearPaciente = function () {
        $location.path('/DrPhischel/Doctor/crearPaciente');
    };

    //Changed the view to Agregate historial
    $scope.goAgregarHistorial = function () {
        $location.path('/DrPhischel/Doctor/agregarHistorial');
    };

    //Changed the view to the historial view
    $scope.goVerHistorial = function () {
        $location.path('/DrPhischel/Doctor/verHistorial');
    };
}]);
