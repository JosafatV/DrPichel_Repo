var urlPaciente = 'Paciente';
angular.module('DrPhischelApp').controller('agregarHistorialTablaController', ['$scope', '$routeParams',
    '$location', 'drPhischelApiResource', function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.listaPacientes = drPhischelApiResource.query({ type: urlPaciente });
        $scope.goAgregarHistorialClienteEspecifico = function (index) {
            $location.path('/DrPhischel/Doctor/AgregarHistorial/' + $scope.listaPacientes[index].idUsuario);
        };
    }]);