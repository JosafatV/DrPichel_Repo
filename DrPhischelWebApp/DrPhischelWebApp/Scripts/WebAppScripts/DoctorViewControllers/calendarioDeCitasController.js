﻿var usuarioActual = 1;
angular.module('DrPhischelApp').controller('calendarioDeCitasController', ['$scope', '$routeParams', 'drPhischelApiResource',
    '$location', '$filter', function ($scope, $routeParams, drPhischelApiResource, $location, $filter) {
        $scope.idDoctorActual = 6;
        alert('Estoy en calendario de citas controller');
        $scope.tablaCitasFlag = true;
        $scope.dateCita = ''
        $scope.citas = '';

        $scope.goAgregarHistorial = function () {
            $location.path('DrPhischel/Doctor/AgregarHistorial');
        };
        //Send the request for the citas
        $scope.verCitas = function () {
            //Filter that filter a date as I need to send it to the web API
            $scope.dateCitaFiltered = $filter('date')($scope.dateCita, 'yyyy-MM-dd');            
            drPhischelApiResource.query({
                type: 'Cita', extension: 'FechaHora', extension2: $scope.dateCitaFiltered,
                extension3: 'Doctor', id: $scope.idDoctorActual}).$promise.then(function (data) {
                    $scope.citas = data;
                    $scope.tablaCitasFlag = false;
                });
        };

    }]);