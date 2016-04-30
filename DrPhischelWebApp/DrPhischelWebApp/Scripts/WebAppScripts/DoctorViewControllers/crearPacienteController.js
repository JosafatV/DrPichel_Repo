//This controller is used to send data information about new clients to the Web API
angular.module('DrPhischelApp').controller('crearPacienteController', ["$scope", "$routeParams", "$location",
function ($scope, $routeParams, $location) {

    //This is where I define the new client to save in the database
    $scope.nuevoCliente = {nombre : '', apellidos : '', edad : '', nss: '', sexo: ''};

    //Function that change the sex when the user choose Female or Male
    $scope.cambieSexo = function (nuevoSexo) {
        $scope.nuevoCliente.sexo = nuevoSexo;
        alert(angular.toJson($scope.nuevoCliente));
    };

    //Function that send the client information to the database to be saved
    $scope.enviarNuevoCliente = function () {
        alert('Esta en envia')
    };
}]);