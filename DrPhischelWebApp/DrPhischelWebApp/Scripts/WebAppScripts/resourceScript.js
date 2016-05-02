
var urlGeneric = 'http://sebastian95:8090/api';
var urlPaciente = 'Paciente';
var urlHistorial = 'Historial';
angular.module('DrPhischelApp').factory('drPhischelApiResource', function ($resource) {
    return $resource(urlGeneric + '/:type/:extension/:extension2/:id', {}, {
        query: {
            method: 'GET',
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8' },
            transformResponse: function (data) {
                return angular.fromJson(data);
            },
            isArray: true
        }, 
        save: {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            }
        },
        update: { method: 'PUT'    },
        delete: { method: 'DELETE' }
    });
});

angular.module('DrPhischelApp').factory('prueba', function ($resource) {
    return $resource('http://sebastian95:8090/api/Paciente', {}, {
        query: {
            method: 'GET',
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8' },
            withCredentials: true,
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            transformResponse: function (data) {
                return angular.fromJson(data);
            },
            isArray: true
        },
        save: {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            }
        },
        update: { method: 'PUT' },
        delete: { method: 'DELETE' }

    });
});

