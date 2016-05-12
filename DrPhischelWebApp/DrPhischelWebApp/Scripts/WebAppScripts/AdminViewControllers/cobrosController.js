angular.module('DrPhischelApp').controller('cobrosController', ['$scope', '$routeParams','drPhischelApiResource','$filter' ,
    '$location', function ($scope, $routeParams, drPhischelApiResource,$filter, $location) {
        //With this function we call the cobros controller 
        $scope.verCobros = function () {
            //Date filtered to send to the database
            $scope.dateCitaFiltered = $filter('date')($scope.dateCobro, 'yyyy-MM-dd');
            drPhischelApiResource.query({ type: 'Doctor', extension: 'Cobros', extension2: $scope.dateCitaFiltered }).$promise.then(function (data) {
                $scope.docsAlCobro = data;

            })
        };

    
    }]);