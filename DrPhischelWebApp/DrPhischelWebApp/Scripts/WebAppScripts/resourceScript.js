
var urlGeneric = 'http://sebastian95:8090/api/';
var urlPaciente = 'Paciente';
var urlHistorial = 'Historial';
angular.module('DrPhischelApp').factory('drPhischelApiResource', function ($resource) {
    return $resource(urlGeneric + ':type/:extension/:id', {}, {
        query: {
            method: 'GET',
            transformResponse: function (data) {
                return angular.fromJson(data);
            },
            isArray: true
        },
        update: { method: 'PUT' },
        delete: { method: 'DELETE' }
    });
});

angular.module('DrPhischelApp').factory('prueba', function ($resource) {
    return $resource('http://sebastian95:8090/api/Paciente', {}, {
        query: {
            method: 'GET',
            transformResponse: function (data) {
                return angular.fromJson(data);
            },
            isArray: true
        },
        update: { method: 'PUT' },
        delete: { method: 'DELETE' }
    });
});
