var urlPaciente = 'Paciente';
angular.module('DrPhischelApp').controller('agregarHistorialTablaController', ['$scope', '$routeParams',
    '$location', 'drPhischelApiResource', function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.listaPacientes = drPhischelApiResource.query({ type: urlPaciente });
        //Changed the view to the VerHistorialClienteEspecifico
        $scope.goAgregarHistorialClienteEspecifico = function (index) {
            //alert(angular.toJson($scope.listaPacientes[index].idUsuario));
            $location.path('/DrPhischel/Doctor/AgregarHistorial/' + $scope.listaPacientes[index].idUsuario);
        };
    }]);