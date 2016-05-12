angular.module('DrPhischelApp').controller('solicitarCitaController', ['$scope', '$routeParams', '$location', 'drPhischelApiResource',
    function ($scope, $routeParams, $location, drPhischelApiResource) {
        $scope.idPaciente = usuarioActual;
        $scope.checked = true;
        $scope.ciudadFlag = false;
        $scope.espeFlag = false;
        $scope.Especialidades = drPhischelApiResource.query({ type: 'Doctor', extension: 'Especialidades' });
        $scope.Ciudades = drPhischelApiResource.query({ type: 'Doctor', extension: 'Ciudades' });
        $scope.especialidadActual = '1';
        $scope.ciudadActual = 'A';
        $scope.dateTime = '';
        $scope.citaResponse = 'A';
        //This function is used to enable the doctors 
        $scope.habiliteDoctor = function () {
            $scope.doctores = drPhischelApiResource.query({ type: 'Doctor', extension: 'Ciudad', extension3: 'Especialidad', extension2: $scope.ciudadActual, id: $scope.especialidadActual })
            $scope.checked = false;
        };
        //This function is used to change the especialidad of every doctor 
        $scope.cambiarEspecialidadActual = function () {                        
            $scope.especialidadActual = $scope.espeSelected.NoEspecialidad;           
            $scope.ciudadFlag = true;
            $scope.doctores = drPhischelApiResource.query({ type: 'Doctor', extension: 'Ciudad', extension3: 'Especialidad', extension2: $scope.ciudadActual, id: $scope.especialidadActual })
        };
        //Change the actual city
        $scope.cambiarCiudadActual = function () {
            $scope.ciudadActual = $scope.ciuSelected;
            $scope.ciudadActual = $scope.ciudadActual.trim();
            $scope.espeFlag = true;
            $scope.doctores = drPhischelApiResource.query({ type: 'Doctor', extension: 'Ciudad', extension3: 'Especialidad', extension2: $scope.ciudadActual, id: $scope.especialidadActual })
        };
        //Change the actual doctor 
        $scope.cambiarDoctorActual = function () {
            $scope.doctorActual = $scope.docSelected;
        };

        //alert the error when one date is already taken 
        $scope.alerteErrorCita = function () {
            alert('Horario de cita ocupado, escoja otro horario')
        };

        $scope.prueba = function () {

            var date = new Date($scope.dateTime);

            //alert(date);
            date = new Date(date.getUTCFullYear(), date.getUTCMonth(), date.getUTCDate(),  date.getUTCHours(), date.getUTCMinutes(), date.getUTCSeconds());
            $scope.nuevaSolicitud = {
                NoDoctor: $scope.doctorActual.idUsuario, FechaHora: date, Estado: 'P',
                idPaciente: $scope.idPaciente
            };
            drPhischelApiResource.save({ type: 'Cita' }, $scope.nuevaSolicitud).$promise.then(function (data) {
                //alert(angular.toJson(data));
                $scope.citaResponse = data.NoCita;
            });

        };

    }]);