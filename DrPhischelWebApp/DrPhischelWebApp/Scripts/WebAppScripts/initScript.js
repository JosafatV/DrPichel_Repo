angular.module('DrPhischelApp', ['ngRoute', 'ngResource']);

angular.module('DrPhischelApp').config(['$routeProvider', function ($routeProvider) {
    $routeProvider

     /*--------------------For the views of the Doctors------------------------------*/

    .when('/DrPhischel/Doctor/agregarHistorial', {
        templateUrl: 'VistaDoctor/agregarHistorial.html',
        controller: 'agregarHistorialController'
    })
    .when('/DrPhischel/Doctor/verHistorial', {
        templateUrl: 'verHistorial.html',
        controller: 'verHistorialController'
    })
    .when('/DrPhischel/Doctor/crearPaciente', {
        templateUrl: 'VistaDoctor/vistaCrearPaciente.html',
        controller: 'crearPacienteController'
    })
    .when('/DrPhischel/Doctor/calendarioCitas', {
        templateUrl: 'calendarioCitas.html',
        controller: 'calendarioCitasController'
    })
    .when('/DrPhischel/DoctorMenu', {
        templateUrl: 'vistaDoctor.html',
        controller: 'menuDoctorController'
    })

    /*--------------------For the views of the Patients------------------------------*/


    .when('/DrPhischel/Patient/HistorialMedico', {
        templateUrl: 'VistaPaciente/historialPaciente.html',
        controller : 'historialPacienteController'
    })
    .when('/DrPhischel/Patient', {
        templateUrl: 'VistaPaciente/vistaPaciente.html',
        controller: 'menuPacienteController'
    })
    .when('/DrPhischel/Patient/SolicitarCita', {
        templateUrl: 'VistaPaciente/solicitarCita.html',
        controller: 'solicitarCitaController'
    })

    /*-----------------For the views of the Admin---------------------------*/
    .when('/DrPhischel/Admin', {
        templateUrl: 'VistaAdmin/vistaAdmi.html',
        controller: 'menuAdminController'
    })
    .when('/DrPhischel/Admin/DoctoresPendientes', {
        templateUrl: 'VistaAdmin/doctoresPendientes.html',
        controller:  'doctoresPendientesController'
    })
    .when('/DrPhischel/Admin/SincronizarMedicamentos', {
        templateUrl: 'VistaAdmin/sincronizarMedicamentos.html',
        controller: 'sincronizarMedicamentosController'
    })
    .when('/DrPhischel/Admin/Cobros', {
        templateUrl: 'VistaAdmin/cobros.html',
        controller: 'cobrosController'
    })
    .otherwise({
        templateUrl: 'VistaDoctor/vistaDoctor.html',
        controller: 'menuDoctorController'
    })
}]);

