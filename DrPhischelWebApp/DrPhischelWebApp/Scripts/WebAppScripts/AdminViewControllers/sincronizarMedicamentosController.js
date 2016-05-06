angular.module('DrPhischelApp').controller('sincronizarMedicamentosController', ['$scope', '$routeParams', 'drPhischelApiResource',
    '$location', 'farmaticaPhischelResource', function ($scope, $routeParams, drPhischelApiResource, $location, farmaticaPhischelResource) {
        $scope.listaSuc = '';

        drPhischelApiResource.delete({ type: 'MedicamentoPorSucursal' }, {});

        farmaticaPhischelResource.query({ type: 'Sucursal' }).$promise.then(function (data) {
            $scope.listaSuc = data;
            drPhischelApiResource.saveList({type:'Sucursal',extension:'List'},data);
        });
        
        farmaticaPhischelResource.query({ type: 'Medicamento' }).$promise.then(function (data) {
            drPhischelApiResource.saveList({ type: 'Medicamento', extension: 'List' }, data);            
        });

        farmaticaPhischelResource.query({ type: 'MedicamentoPorSucursal' }).$promise.then(function (data) {
            angular.forEach(data, function (value, key) {
                //alert(angular.toJson(value));
                drPhischelApiResource.save({
                    type: 'MedicamentoPorSucursal', extension: 'Sucursal', extension2: value.NoSucursal,
                    extension3: 'Medicamento', extension4: value.CodigoMedicamento, extension5: 'Cantidad', id: value.Cantidad
                }, {});
            });
        });

        $scope.llameMeds = function (index) {
            //$scope.idActual = $scope.listaSuc[index].id;
            //alert(index);            
            farmaticaPhischelResource.query({ type: 'MedicamentoPorSucursal', extension2: index }).$promise.then(function (data) {
                drPhischelApiResource.post({ type: 'Medicamento',extension:'Sucursal' ,extension2: 'List' }, data);                
            });

        };
        //drPhischelApiResource.query({ type: 'MedicamentoEnSucursal', extension: $scope.sucId });
    }]);