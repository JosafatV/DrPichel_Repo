var urlPaciente = 'Paciente';
angular.module('DrPhischelApp').controller('verHistorialClienteEspecificoController', ['$scope', '$routeParams',
    '$location', 'drPhischelApiResource', function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.pacienteActual = clienteActual;
        $scope.listaHistorial = drPhischelApiResource.query({ type: urlHistorial, extension: urlPaciente, id:$routeParams.index});
        $scope.goRecetasDeHistorial = function (index) {
            $scope.NoAtencion = $scope.listaHistorial[index].NoAtencion
            $location.path('/DrPhischel/Doctor/VerRecetasDeHistorial/' + $scope.NoAtencion);
        }
    }]);