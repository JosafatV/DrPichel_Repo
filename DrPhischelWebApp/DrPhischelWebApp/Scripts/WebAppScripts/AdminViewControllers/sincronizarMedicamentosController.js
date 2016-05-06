angular.module('DrPhischelApp').controller('sincronizarMedicamentosController', ['$scope', '$routeParams', 'drPhischelApiResource',
    '$location', 'farmaticaPhischelResource', function ($scope, $routeParams, drPhischelApiResource, $location, farmaticaPhischelResource) {
        $scope.listaSuc = '';
        farmaticaPhischelResource.query({ type: 'Sucursal' }).$promise.then(function (data) {
            //alert(angular.toJson(data));
            $scope.listaSuc = data;
        });

        farmaticaPhischelResource.query({ type: 'Medicamento' }).$promise.then(function (data) {
            //alert(angular.toJson(data));
            angular.forEach(data, function (value, key) {
                alert(angular.toJson(value));
                drPhischelApiResource.save({ type: 'Medicamento'}, value);
            });
            //drPhischelApiResource.save({ type: 'Medicamento', extension: 'List' }, data);            
        });

        $scope.llameMeds = function (index) {
            //$scope.idActual = $scope.listaSuc[index].id;
            //alert(index);            
            farmaticaPhischelResource.query({ type: 'Medicamento',extension:'Sucursal', extension2: index }).$promise.then(function (data) {
                drPhischelApiResource.post({ type: 'Medicamento',extension:'Sucursal' ,extension2: 'List' }, data);                
            });

        };
        //drPhischelApiResource.query({ type: 'MedicamentoEnSucursal', extension: $scope.sucId });
    }]);