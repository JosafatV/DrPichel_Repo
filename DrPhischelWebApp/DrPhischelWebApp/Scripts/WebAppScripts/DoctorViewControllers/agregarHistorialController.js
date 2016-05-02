angular.module('DrPhischelApp').controller('agregarHistorialController', ["$scope", "$routeParams", "$location","drPhischelApiResource",
    function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.newHistorial = {};
        $scope.sendHistorial = function () {
            drPhischelApiResource.save({type:'Historial',extension:'Atenciones',extension2:'Paciente'})
        };


        alert('Entro agregar historial controller');
    }]);