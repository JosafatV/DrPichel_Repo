angular.module('DrPhischelApp').controller('cobrosController', ['$scope', '$routeParams','drPhischelApiResource',
    '$location', function ($scope, $routeParams, $location, drPhischelApiResource) {

        $scope.verCobros = function () {
            drPhischelApiResource.query({ type: 'Doctor', extension: 'Cobros', extension2: $scope.dateCobro }).$promise.then(function (data) {
                $scope.docsAlCobro = data;
                //alert(data);
            })
        };

    
    }]);