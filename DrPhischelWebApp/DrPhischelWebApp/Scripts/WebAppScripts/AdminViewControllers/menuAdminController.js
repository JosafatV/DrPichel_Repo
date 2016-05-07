angular.module('DrPhischelApp').controller('menuAdminController', ['$scope', '$routeParams',
    '$location', function ($scope, $routeParams, $location) {
        //Changed the view to the AgregarPaciente
        $scope.goAgregarPaciente = function () {
            $location.path('/DrPhischel/Doctor/CrearPaciente');
        };
        //Changed the view to the VerDoctoresPendientes
        $scope.goVerDoctoresPendientes = function () {
            $location.path('/DrPhischel/Admin/DoctoresPendientes');
        };
        //Changed the view to the SincronizarMedicamentos
        $scope.goSincronizarMedicamentos = function () {
            $location.path('/DrPhischel/Admin/SincronizarMedicamentos');
        };
        //Changed the view to the Cobros
        $scope.goCobros = function () {
            $location.path('/DrPhischel/Admin/Cobros');
        };
    }]);