﻿//This controller is used to send data information about new clients to the Web API
angular.module('DrPhischelApp').controller('crearPacienteController', ["$scope", "$routeParams", "$location", "drPhischelApiResource", "prueba",
function ($scope, $routeParams, $location, drPhischelApiResource, prueba) {
    //$scope.op = drPhischelApiResource.query({ type: urlPaciente });
    //This is where I define the new client to save in the database
    $scope.nuevoCliente = {nombre : '', apellidos : '', sexo: '',FechaNacimiento:'',altura:'',peso:''};

    //Function that change the sex when the user choose Female or Male
    $scope.cambieSexo = function (nuevoSexo) {
        $scope.nuevoCliente.sexo = nuevoSexo;
        alert(angular.toJson($scope.nuevoCliente));
    };

    //Function that send the client information to the database to be saved
    $scope.enviarNuevoCliente = function () {
       // alert(angular.toJson($scope.op));
        //drPhischelApiResource.save({ type: urlPaciente }, $scope.nuevoCliente);
        prueba.save({ nombre: 's', apellidos: 'a', sexo: 'F', FechaNacimiento: '2013-2-5', altura: '1', peso: '1' });
    };
}]);