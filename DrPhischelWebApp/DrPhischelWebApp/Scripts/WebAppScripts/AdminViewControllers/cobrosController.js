angular.module('DrPhischelApp').controller('cobrosController', ['$scope', '$routeParams','drPhischelApiResource','$filter' ,
    '$location', function ($scope, $routeParams, drPhischelApiResource,$filter, $location) {

        $scope.verCobros = function () {
            $scope.dateCitaFiltered = $filter('date')($scope.dateCobro, 'yyyy-MM-dd');
            alert($scope.dateCitaFiltered);
            drPhischelApiResource.query({ type: 'Doctor', extension: 'Cobros', extension2: $scope.dateCitaFiltered }).$promise.then(function (data) {
                $scope.docsAlCobro = data;

            })
        };

    
    }]);