//This controller is used to send data information about new clients to the Web API
angular.module('DrPhischelApp').controller('crearPacienteController', ["$scope", "$routeParams", "$location", "$http", "drPhischelApiResource", "farmaticaPhischelResource",
function ($scope, $routeParams, $location, $http, drPhischelApiResource, farmaticaPhischelResource) {
    //This is where I define the new client to save in the database
    $scope.nuevoCliente = {Cedula:'',nombre : '', apellido : '', FechaNacimiento:'',Residencia:'',altura:'',peso:''};

    //Function that change the sex when the user choose Female or Male
    $scope.cambieSexo = function (nuevoSexo) {
        //$scope.nuevoCliente.sexo = nuevoSexo;
        alert(angular.toJson($scope.nuevoCliente));
    };

    //Function that send the client information to the database to be saved
    $scope.enviarNuevoCliente = function () {
        drPhischelApiResource.save({ type: 'Paciente' }, $scope.nuevoCliente);
        farmaticaPhischelResource.save({ type: 'Client' }, $scope.nuevoCliente);

    };
}]);