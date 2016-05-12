var urlPaciente = 'Paciente';
angular.module('DrPhischelApp').controller('verHistorialClienteEspecificoController', ['$scope', '$routeParams',
    '$location', 'drPhischelApiResource', function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.pacienteActual = clienteActual;
        //Here I ask for the historial list
        $scope.listaHistorial = drPhischelApiResource.query({ type: urlHistorial, extension: urlPaciente, id:$routeParams.index});
        //Function to change the view to the GorecetasDeHistorial
        $scope.goRecetasDeHistorial = function (index) {
            $scope.NoAtencion = $scope.listaHistorial[index].NoAtencion
            $location.path('/DrPhischel/Doctor/VerRecetasDeHistorial/' + $scope.NoAtencion);
        }
    }]);