
angular.module('DrPhischelApp').controller("menuDoctorController", ["$scope","$location",

function ($scope, JsonResource) {
    
    $scope.goAgregarHistorial = function () {
        $location.path('DrPhischel/Doctor/agregarHistorial');
    };

    $scope.goVerHistorial = function () {
        $location.path('DrPhischel/Doctor/verHistorial');
    };

    $scope.prueba = function () {
        alert('Estan sirviendo')
    }
}]);
