
angular.module('DrPhischelApp').controller("portadaController", ["$scope",'JsonResource',

function ($scope, JsonResource) {
    $scope.alerte = function () {
        alert('Estan sirviendo los doctores')
    }
}]);
