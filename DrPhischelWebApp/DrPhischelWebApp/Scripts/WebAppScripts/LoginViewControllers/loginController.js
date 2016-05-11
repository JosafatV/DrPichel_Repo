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
        $scope.cedula = 0;
        $scope.contra = 0;
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
            alert('no esta registrado idiota');
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
        };
        $scope.activePaciente = function () {
            $scope.pacienteDisponible = true;
        };
        $scope.activeAdmin = function () {
            $scope.adminDisponible = true;
        };
        $scope.goAdminView = function () {
            $location.path('/DrPhischel/Admin');
        };
        $scope.goDoctorView = function () {
            $location.path('/DrPhischel/DoctorMenu');
        };
        $scope.goPacienteView = function () {
            $location.path('/DrPhischel/Patient');
        };
    }]);