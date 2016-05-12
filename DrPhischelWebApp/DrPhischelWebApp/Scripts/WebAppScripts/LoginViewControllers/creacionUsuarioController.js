//This controller is used to send data information about new clients to the Web API
angular.module('DrPhischelApp').controller('creacionUsuarioController', ["$scope", "$routeParams", "$location", "$http", "drPhischelApiResource", "farmaticaPhischelResource",
function ($scope, $routeParams, $location, $http, drPhischelApiResource, farmaticaPhischelResource) {
    $scope.Especialidades = drPhischelApiResource.query({ type: 'Doctor', extension: 'Especialidades' });
    $scope.enviarFlag = false;
    //This is where I define the new doctor to save in the database
    $scope.nuevoCliente = {
        cedula: '', nombre: '',password: '', apellido: '', FechaNacimiento: '', Residencia: '', Estado: 'I', DireccionConsultorio: '', Especialidad: '',
        TarjetaCredito: '', CidudadConsultorio: ''
    };

    //Change the especialidad del nuevo doctor a insertar
    $scope.cambiarEspecialidadActual = function () {
        $scope.especialidadActual = $scope.espeSelected.NoEspecialidad;
        $scope.enviarFlag = true;
        $scope.nuevoCliente.Especialidad = $scope.espeSelected.NoEspecialidad;
    };

    //Function that send the doctor information to the database to be saved
    $scope.enviarNuevoCliente = function () {
        drPhischelApiResource.save({ type: 'Doctor' }, $scope.nuevoCliente);
        //farmaticaPhischelResource.save({ type: 'Client' }, $scope.nuevoCliente);

    };
}]);