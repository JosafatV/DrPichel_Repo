
angular.module('DrPhischelApp').controller('verHistorialClienteEspecificoController', ['$scope', '$routeParams',
    '$location', 'drPhischelApiResource', function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.listaHistorial = drPhischelApiResource.query({ type: urlHistorial, extension: urlPaciente, id:$routeParams.index});
        $scope.prueba = function () {
            alert(global);
            //alert(angular.toJson($scope.listaHistorial));
        }
    }]);