angular.module('DrPhischelApp').controller('doctoresPendientesController', ['$scope', '$routeParams',
    '$location', 'drPhischelApiResource', function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.doctoresPendientes = drPhischelApiResource.query({
            type: 'Doctor', extension: 'Estado', extension2: 'I'
        });
        $scope.aceptarDoctor = function (index) {
            $scope.doctorModificado = $scope.doctoresPendientes[index];
            $scope.doctorModificado.Estado = 'A';
            drPhischelApiResource.update({type:'Doctor'},angular.toJson($scope.doctorModificado));
        }
    }]);