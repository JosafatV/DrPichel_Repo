angular.module('DrPhischelApp').config(['$routeProvider', function ($routeProvider) {
    $routeProvider

     /*--------------------For the views of the Doctors------------------------------*/

    .when('/DrPhischel/Doctor/AgregarHistorial/:index/:nombre', {
        templateUrl: 'VistaDoctor/agregarHistorial.html',
        controller: 'agregarHistorialController'
    })
    .when('/DrPhischel/Doctor/VerHistorial', {
        templateUrl: 'VistaDoctor/verHistorial.html',
        controller: 'verHistorialController'
    })
    .when('/DrPhischel/Doctor/VerHistorialClienteEspecifico/:index', {
        templateUrl: 'VistaDoctor/verHistorialClienteEspecifico.html',
        controller: 'verHistorialClienteEspecificoController'
    })
    .when('/DrPhischel/Doctor/CrearPaciente', {
        templateUrl: 'VistaDoctor/vistaCrearPaciente.html',
        controller: 'crearPacienteController'
    })
    .when('/DrPhischel/Doctor/CalendarioCitas', {
        templateUrl: 'calendarioCitas.html',
        controller: 'calendarioCitasController'
    })
    .when('/DrPhischel/Doctor/AgregarHistorialTabla', {
        templateUrl: 'VistaDoctor/agregarHistorialTabla.html',
        controller: 'agregarHistorialTablaController'
    })
    .when('/DrPhischel/Doctor/VerRecetasDeHistorial/:index', {
        templateUrl: 'VistaDoctor/verRecetasDeHistorial.html',
        controller: 'verRecetasDeHistorialController'
    })
    .when('/DrPhischel/DoctorMenu', {
        templateUrl: 'vistaDoctor.html',
        controller: 'menuDoctorController'
    })
    .when('/DrPhischel/Doctor/calendarioDeCitas', {
        templateUrl: 'VistaDoctor/calendarioDeCitas.html',
        controller: 'calendarioDeCitasController'
    })

    /*--------------------For the views of the Patients------------------------------*/


    .when('/DrPhischel/Patient/HistorialMedico', {
        templateUrl: 'VistaPaciente/historialPaciente.html',
        controller: 'historialPacienteController'
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
        controller: 'doctoresPendientesController'
    })
    .when('/DrPhischel/Admin/SincronizarMedicamentos', {
        templateUrl: 'VistaAdmin/sincronizarMedicamentos.html',
        controller: 'sincronizarMedicamentosController'
    })
    .when('/DrPhischel/Admin/Cobros', {
        templateUrl: 'VistaAdmin/cobros.html',
        controller: 'cobrosController'
    })

    /*
    .otherwise({
        templateUrl: 'VistaPaciente/vistaPaciente.html',
        controller: 'menuPacienteController'
    })*/
    /*
    .otherwise({
        templateUrl: 'VistaDoctor/vistaDoctor.html',
        controller: 'menuDoctorController'
    })*/
    
    .otherwise({
        templateUrl: 'VistaAdmin/vistaAdmi.html',
        controller: 'menuAdminController'
    })
}]);

angular.module('DrPhischelApp').config(function ($httpProvider) {
    //$httpProvider.defaults.headers.common = {};
    $httpProvider.defaults.useXDomain = true;
    $httpProvider.defaults.headers.post['Content-Type'] = 'application/json;charset=utf-8';
    //$httpProvider.defaults.headers.post['Content-Type'] = 'application/x-www-form-urlencoded;charset=utf-8';
    //$httpProvider.defaults.withCredentials = true;
    //delete $httpProvider.defaults.headers.common["X-Requested-With"];
    //$httpProvider.defaults.headers.common = {};
    /*$httpProvider.defaults.headers.post = {};
    $httpProvider.defaults.headers.put = {};
    $httpProvider.defaults.headers.patch = {};*/
});