﻿angular.module('DrPhischelApp').controller('agregarHistorialController', ["$scope", "$routeParams", "$location","drPhischelApiResource",
    function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.Especialidades = drPhischelApiResource.query({type:'Doctor',extension:'Especialidades'});
        //$scope.newHistorial = {Descripcion:'s',Estudios:'d',NoCita:'1'};
        $scope.sendHistorial = function () {
            alert(angular.toJson($scope.Especialidades));
            //drPhischelApiResource.save({type:'Historial',extension:'Atenciones',extension2:'Paciente'},{})
        };
    }]);