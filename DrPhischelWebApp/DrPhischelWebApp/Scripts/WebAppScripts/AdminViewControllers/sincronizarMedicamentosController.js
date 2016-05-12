angular.module('DrPhischelApp').controller('sincronizarMedicamentosController', ['$scope', '$routeParams', 'drPhischelApiResource',
    '$location', 'farmaticaPhischelResource', function ($scope, $routeParams, drPhischelApiResource, $location, farmaticaPhischelResource) {
        $scope.listaSuc = '';
        $scope.tablaFlag = true;
        //Here I delete the medicamentos por sucursal before sincronize
        drPhischelApiResource.delete({ type: 'MedicamentoPorSucursal' }, {});
        farmaticaPhischelResource.query({ type: 'Sucursal' }).$promise.then(function (data) {
            $scope.listaSuc = data;
        });
        //This function is used to sincronize and save every table of the database
        $scope.sincronizar = function () {
            //ask for sucursales
            farmaticaPhischelResource.query({ type: 'Sucursal' }).$promise.then(function (data) {
                $scope.listaSuc = data;
                drPhischelApiResource.saveList({ type: 'Sucursal', extension: 'List' }, data);
            });
            //ask for medicamentos
            farmaticaPhischelResource.query({ type: 'Medicamento' }).$promise.then(function (data) {
                drPhischelApiResource.saveList({ type: 'Medicamento', extension: 'List' }, data);
            });
            //ask for medicamentos por sucursal
            farmaticaPhischelResource.query({ type: 'MedicamentoPorSucursal' }).$promise.then(function (data) {
                angular.forEach(data, function (value, key) {
                    //alert(angular.toJson(value));
                    drPhischelApiResource.save({
                        type: 'MedicamentoPorSucursal', extension: 'Sucursal', extension2: value.NoSucursal,
                        extension3: 'Medicamento', extension4: value.CodigoMedicamento, extension5: 'Cantidad', id: value.Cantidad
                    }, {});
                });
            });
        };

        $scope.llameMeds = function (index, nombre) {
            $scope.sucActualidad = nombre;
            $scope.tablaFlag = false;
            drPhischelApiResource.query({ type: 'Medicamento', extension: 'Sucursal', extension2: index }).$promise.then(function (data) {
                $scope.medsDeSucursalSelected = data;
            });

        };

        $scope.regresar = function () {
            $location.path('/DrPhischel/Admin');
        };
    }]);