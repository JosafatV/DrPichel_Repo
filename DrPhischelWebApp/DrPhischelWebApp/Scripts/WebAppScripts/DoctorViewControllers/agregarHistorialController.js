angular.module('DrPhischelApp').controller('agregarHistorialController', ["$scope", "$routeParams", "$location","drPhischelApiResource",
    function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.newHistorial = {Descripcion:'s',Estudios:'d',NoCita:'1'};
        $scope.sendHistorial = function () {
            drPhischelApiResource.save({type:'Historial',extension:'Atenciones',extension2:'Paciente'},{})
        };
    }]);