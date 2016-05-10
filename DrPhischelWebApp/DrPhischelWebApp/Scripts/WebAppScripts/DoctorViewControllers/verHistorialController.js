var urlPaciente = 'Paciente';
var clienteActual = '';
angular.module('DrPhischelApp').controller('verHistorialController', ['$scope', '$routeParams',
    '$location', 'drPhischelApiResource', function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.listaPacientes = drPhischelApiResource.query({ type: urlPaciente});
        //Changed the view to the VerHistorialClienteEspecifico
        $scope.goVerHistorialClienteEspecifico = function (index) {
            //alert(angular.toJson($scope.listaPacientes[index].idUsuario));
            clienteActual = $scope.listaPacientes[index];
            $location.path('/DrPhischel/Doctor/VerHistorialClienteEspecifico/' + $scope.listaPacientes[index].idUsuario);
        };
        $scope.back = function () {
            $location.path('VistaDoctor/vistaDoctor.html');
        };
    }]);