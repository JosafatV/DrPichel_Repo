var usuarioActual = '';
var docActual = '';
angular.module('DrPhischelApp').controller('loginController', ['$scope', '$routeParams', 'drPhischelApiResource',
    '$location', 'farmaticaPhischelResource', function ($scope, $routeParams, drPhischelApiResource, $location, farmaticaPhischelResource) {
        $scope.contra = '';
        $scope.cedula = '';
        $scope.listaRoles = [];
        $scope.listaRolesLength = 100;
        $scope.doctorDisponible = false;
        $scope.pacienteDisponible = false;
        $scope.adminDisponible = false;
        $scope.pediLosRoles = false;        
        //$scope.cedula = 0;
        //$scope.contra = 0;
        $scope.ingresar = function () {
            $scope.listaRoles = '';
            $scope.doctorDisponible = false;
            $scope.pacienteDisponible = false;
            $scope.adminDisponible = false;
            drPhischelApiResource.query({type:'LogInUser',extension:'Cedula',extension2:$scope.cedula,
                extension3: 'Password', extension4: $scope.contra
            }).$promise.then(function (data) {                
                $scope.listaRolesLength = data.length;
                $scope.listaRoles = data;
                $scope.pediLosRoles = true;
            });
        };
        $scope.alerteNoRegistrado = function () {
            alert('No es un usuario registrado');
        };
        $scope.esPaciente = function (rol) {
            return rol === '1';
        };
        $scope.esDoctor = function (rol) {
            return rol === '2';
        };
        $scope.esAdmin = function (rol) {
            return rol === '3';
        };
        $scope.activeDoctor = function () {
            $scope.doctorDisponible = true;
            docActual = $scope.listaRoles[0].id;
            usuarioActual = $scope.listaRoles[0].id;
        };
        $scope.activePaciente = function () {
            $scope.pacienteDisponible = true;
            docActual = $scope.listaRoles[0].id;
            usuarioActual = $scope.listaRoles[0].id;
        };
        $scope.activeAdmin = function () {
            $scope.adminDisponible = true;
            docActual = $scope.listaRoles[0].id;
            usuarioActual = $scope.listaRoles[0].id;
        };
        $scope.goAdminView = function () {
            $location.path('/DrPhischel/Admin/Menu');
        };
        $scope.goDoctorView = function () {
            $location.path('/DrPhischel/DoctorMenu');
        };
        $scope.goPacienteView = function () {
            $location.path('/DrPhischel/Patient');
        };
    }]);