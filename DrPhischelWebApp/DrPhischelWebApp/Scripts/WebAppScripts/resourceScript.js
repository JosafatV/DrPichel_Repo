angular.module('DrPhischelApp').factory('JsonResource', function ($resource) {
    return $resource('http://localhost:8080/api/Client/:id', {}, {
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