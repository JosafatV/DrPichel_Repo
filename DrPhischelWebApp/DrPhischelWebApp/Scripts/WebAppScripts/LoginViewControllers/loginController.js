angular.module('DrPhischelApp').controller('loginController', ['$scope', '$routeParams', 'drPhischelApiResource',
    '$location', 'farmaticaPhischelResource', function ($scope, $routeParams, drPhischelApiResource, $location, farmaticaPhischelResource) {
        $scope.contra = '';
        $scope.cedula = '';
        drPhischelApiResource.query({ type: 'Sucursal' }).$promise.then(function (data) {
            //alert(angular.toJson(data));
            $scope.listaSuc = data;
        });
        //drPhischelApiResource.query({ type: 'MedicamentoEnSucursal', extension: $scope.sucId });
    }]);