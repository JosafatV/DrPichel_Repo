angular.module('DrPhischelApp').controller('calendarioDeCitasController', ['$scope', '$routeParams', 'drPhischelApiResource',
    '$location', '$filter', function ($scope, $routeParams, drPhischelApiResource, $location, $filter) {
        $scope.idDoctorActual = docActual;
        $scope.tablaCitasFlag = true;
        $scope.dateCita = ''
        $scope.citas = '';
        //Change the view to agregarHistorial
        $scope.goAgregarHistorial = function (index) {
            $location.path('DrPhischel/Doctor/AgregarHistorial/' + $scope.citas[index].idPaciente + '/' + $scope.citas[index].NombrePaciente
                +' ' + $scope.citas[index].ApellidoPaciente);
        };
        //Send the request for the citas
        $scope.verCitas = function () {
            //Filter that filter a date as I need to send it to the web API
            $scope.dateCitaFiltered = $filter('date')($scope.dateCita, 'yyyy-MM-dd');            
            drPhischelApiResource.query({
                type: 'Cita', extension: 'FechaHora', extension2: $scope.dateCitaFiltered,
                extension3: 'Doctor', id: $scope.idDoctorActual}).$promise.then(function (data) {
                    $scope.citas = data;
                    $scope.tablaCitasFlag = false;
                });
        };

    }]);