﻿angular.module('DrPhischelApp').controller('agregarHistorialController', ["$scope", "$routeParams", "$location","drPhischelApiResource",
    function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.nombrePaciente = $routeParams.nombre;
        $scope.checked = true;
        $scope.Especialidades = drPhischelApiResource.query({ type: 'Doctor', extension: 'Especialidades' });
        //This function is used to send a Historial to the web api to be saved.
        $scope.sendHistorial = function () {
            //alert(angular.toJson($scope.Especialidades));
            /*alert(angular.toJson({
                Descripcion: $scope.observaciones,
                Estudios: $scope.estudios,
                NoCita: $routeParams.cita
            }));            */
            drPhischelApiResource.save({ type: 'Historial', extension: 'Atenciones', extension2: 'Paciente', extension3: $routeParams.index }, {
                Descripcion: $scope.observaciones,
                Estudios: $scope.estudios,
                NoCita: $routeParams.cita
            }).$promise.then(function (data) {
                $scope.atencionActual = data.NoAtencion;
                //alert(angular.toJson({ NoAtencion: $scope.atencionActual, NoDoctor: docActual, Estado: 'A' }));
                drPhischelApiResource.save({ type: 'Receta' }, { NoAtencion: $scope.atencionActual, NoDoctor: docActual, Estado: 'A' }).$promise.then(function (data) {
                    //alert(angular.toJson(data));
                    });
            });
        };
        //This is used to put the checked variable true
        $scope.agregarMedicamentos = function () {
            $scope.checked = false;
        };
    }]);