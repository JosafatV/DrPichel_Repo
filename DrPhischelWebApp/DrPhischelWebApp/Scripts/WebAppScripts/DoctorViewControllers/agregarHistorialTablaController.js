var urlPaciente = 'Paciente';
angular.module('DrPhischelApp').controller('agregarHistorialTablaController', ['$scope', '$routeParams',
    '$location', 'drPhischelApiResource','$filter', function ($scope, $routeParams, $location, drPhischelApiResource,$filter) {
        $scope.todayDateFiltered = $filter('date')(new Date(), 'fullDate');
        $scope.idDoctorActual = docActual;
        $scope.citas = '';
        //Send the request for the citas
        //Filter that filter a date as I need to send it to the web API
        $scope.todayDate = $filter('date')(new Date(), 'yyyy-MM-dd');
        drPhischelApiResource.query({
            type: 'Cita', extension: 'FechaHora', extension2: $scope.todayDate,
            extension3: 'Doctor', id: $scope.idDoctorActual
        }).$promise.then(function (data) {
            $scope.citas = data;
        });

        //Change the view for the ver Cliente Especifico
        $scope.goAgregarHistorialClienteEspecifico = function (index) {
            $location.path('/DrPhischel/Doctor/AgregarHistorial/' + $scope.listaPacientes[index].idUsuario);
        };
        
        //Change the view for the insert of a historial
        $scope.goAgregarHistorial = function (index) {
            $location.path('DrPhischel/Doctor/AgregarHistorial/' + $scope.citas[index].idPaciente + '/' + $scope.citas[index].NombrePaciente
                + ' ' + $scope.citas[index].ApellidoPaciente + '/' + $scope.citas[index].NoCita);
        };

        $scope.terminarCita = function (cita) {
            $scope.nuevoJson = { NoCita: cita.NoCita, NoDoctor: cita.NoDoctor, FechaHora: cita.Fecha, Estado: 'C', idPaciente: cita.idPaciente };
            //alert(angular.toJson($scope.nuevoJson));
            drPhischelApiResource.update({ type: 'Cita' }, $scope.nuevoJson);
            //alert(angular.toJson(cita));
            //drPhischelApiResource({ type: 'Cita' }, {NoCita: noCita, NoDoctor: docActual, });
        };




    }]);