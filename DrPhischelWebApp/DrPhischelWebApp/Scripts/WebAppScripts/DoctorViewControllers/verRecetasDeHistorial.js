var urlPaciente = 'Paciente';
angular.module('DrPhischelApp').controller('verRecetasDeHistorialController', ['$scope', '$routeParams',
    '$location', 'farmaticaPhischelResource', 'drPhischelApiResource', function ($scope, $routeParams, $location, farmaticaPhischelResource,
        drPhischelApiResource) {
        $scope.Receta = drPhischelApiResource.get({ type: 'Receta', extension: 'Atencion', extension2: $routeParams.index }).
            $promise.then(function (data) {
                alert(angular.toJson(data));
                $scope.listaMedicamentos = farmaticaPhischelResource.query({type:'MedicamentosPorReceta',id:data.NoReceta});
            });

        $scope.prueba = function () {            
            alert(angular.toJson($scope.listaMedicamentos));
        };
    }]);