angular.module('DrPhischelApp', ['ngRoute', 'ngResource']);

angular.module('DrPhischelApp').config(['$routeProvider', function ($routeProvider) {
    $routeProvider

     /*--------------------Para las vistas de los doctores------------------------------*/

    .when('DrPhischel/Doctor/agregarHistorial', {
        templateUrl: 'agregarHistorial.html',
        controller: 'agregarHistorialController'
    })
    .when('DrPhischel/Doctor/verHistorial', {
        templateUrl: 'verHistorial.html',
        controller: 'verHistorialController'
    })
    .when('DrPhischel/Doctor/agregarPaciente', {
        templateUrl: 'agregarPaciente.html',
        controller: 'agregarPacienteController'
    })
    .when('DrPhischel/Doctor/calendarioCitas', {
        templateUrl: 'calendarioCitas.html',
        controller: 'calendarioCitasController'
    })

    /*--------------------Para las vistas de los Pacientes------------------------------*/


    /*-----------------Para las vistas de los Administradores---------------------------*/

      .otherwise({
          templateUrl: 'VistaDoctor/VistaDoctor.html',
          controller: 'menuDoctorController'
      })
}]);
