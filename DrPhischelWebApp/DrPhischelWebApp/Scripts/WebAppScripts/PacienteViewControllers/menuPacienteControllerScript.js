var usuarioActual = 1;
angular.module('DrPhischelApp').controller('menuPacienteController', ['$scope', '$routeParams',
    '$location', function ($scope,$routeParams,$location) {
        
        //Changed the view to the Historial Medico
        $scope.goVerHistorialMedico = function () {
            $location.path('/DrPhischel/Patient/HistorialMedico');
        };

        //Changed the view to SolicitarCita
        $scope.goSolicitarCita = function () {
            $location.path('/DrPhischel/Patient/SolicitarCita');
        };

        $scope.goVerHistorial = function () {
            $location.path('/DrPhischel/Doctor/VerHistorialClienteEspecifico/' + usuarioActual);
        };

    }]);