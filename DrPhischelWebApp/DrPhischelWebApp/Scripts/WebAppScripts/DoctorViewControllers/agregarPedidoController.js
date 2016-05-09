var pedidoActual = {};
var clienteActual = 1;
var empleadoActual = {};
var listaRecets = [];
var docActual = "Doctores";
var medActual = "Medicamentos";
var sucActual = "Sucursales";
var listaMedicamentosxPedido = [];
var listaMedicamentosxReceta = [];
var listaMedsActuales = [];
var listaMedsActualesPeds = [];
var listaMedsActualesRecs = [];
var newRecetas = [];
var numSuc = 0;
var empSelected = "Empresa";
var docActual = 1;
angular.module('DrPhischelApp').controller("agregarPedidoController", ["$scope", "$location", "$window", "$routeParams", "doctorResource", "sucursalResource", "medResource", "pedidoResource", "telefonosResource",
    "JsonResource", "detallePedidoResource", "detalleRecetaResource", "recetasResource", "detalleRecetaResource", 'farmaticaPhischelResource',

function ($scope, $location, $window, $routeParams, doctorResource, sucursalResource, medResource, pedidoResource, telefonosResource, JsonResource, detallePedidoResource
    , detalleRecetaResource, recetasResource, detalleRecetaResource, farmaticaPhischelResource) {
    $scope.banderaDeCliente = false;
    //Este es el nuevo---------------------
    //Recordar cambiar clienteActual !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1111
    $scope.dochhActual = docActual;
    listaMedicamentosxReceta.push(listaMedsActuales);
    listaMedsActuales = [];
    listaMedsActualesRecs = [];
    //listaRecets.push({ NoFactura: "", IdCliente: clienteActual, NoDoctor: $scope.numeroDoc });

    JsonResource.query().$promise.then(function (data) {
        //$scope.Item = data[parseInt($routeParams.index)];
        $scope.telefonos = telefonosResource.query({ id: clienteActual });
        //$scope.isArray = data instanceof Array;
    });

    $scope.verificarCliente = function (cedula) {
        alert($scope.cedulaCliente);
        farmaticaPhischelResource.get({ type: 'Client', extension: $scope.cedulaCliente }).$promise.then(function (data) {
            $scope.banderaDeCliente = data.Cedula;
            clienteActual = data.IdCliente;
        });        
    };

    $scope.goAgregarCliente = function () {
        $location.path('/DrPhischel/Doctor/CrearPaciente');

    };

    $scope.empSelected = 'P';
    $scope.empList = ["Farmatica", "Phischel"];
    $scope.boolEmpresa = false;
    $scope.empresaBool = "Farmatica";
    $scope.empresaSelec = "F";
    $scope.empresaCambio = function (nueva) {
        $scope.empresaBool = nueva;
        $scope.boolEmpresa = true;
        empSelected = nueva;
        $scope.empSelected = empSelected;
    }
    $scope.cambieEmpresa = function (nueva) {
        $scope.empresaSelec = nueva;
        $scope.boolEmpresa = true;
    }
    $scope.numRec = 3;
    $scope.numRec2 = 4;
    $scope.numFac = 2;
    $scope.Estado = "Nuevo";
    $scope.Empresa = $scope.empresaSelec;
    $scope.docActual = docActual;
    $scope.medActual = medActual;
    $scope.sucActual = sucActual;
    $scope.cantidad = 1;
    //$scope.docList = doctorResource.query();
    $scope.recList = sucursalResource.query();
    $scope.medListP = medResource.query({ presc: 0, nosuc: numSuc });
    $scope.medListR = medResource.query({ presc: "Sucursal", nosuc: numSuc });
    $scope.medListPed = listaMedsActualesPeds;
    $scope.medListRec = listaMedsActualesRecs;
    $scope.plantillaPedido = { NoFactura: "", CodigoMedicamento: "", Cantidad: "" };

    $scope.addNoSuc = function (numeroS, nombre) {
        sucActual = nombre;
        $scope.sucActual = sucActual;
        numSuc = numeroS;
        $scope.medListP = medResource.query({ presc: 0, nosuc: numSuc });
        $scope.medListR = medResource.query({ presc: "Sucursal", nosuc: numSuc });
        //$window.location.reload();
    }
    $scope.addMedPed = function (cant, codMed, nomMed, costo) {
        $scope.medActual = nomMed;
        $scope.newMedxPedido = $scope.plantillaPedido;
        $scope.newMedxPedido.codMed = codMed;
        $scope.newMedxPedido.Cantidad = cant;
        listaMedsActualesPeds.push({ Nombre: nomMed, CodigoMedicamento: codMed, Cantidad: cant, Costo: costo });
        listaMedicamentosxPedido.push({ NoFactura: "", CodigoMedicamento: codMed, Cantidad: cant, NoSucursal: "" });
        //alert(angular.toJson(listaMedicamentosxPedido));
        //Prueba que sirvio-----------------
        /* $scope.newMedxPedido = $scope.plantillaPedido;
         $scope.newMedxPedido.codMed = codMed;
         $scope.listaMedicamentosxPedido.push($scope.newMedxPedido);
         alert(angular.toJson($scope.listaMedicamentosxPedido));
         $scope.listaMedicamentosxPedido[0].NoFactura = 3;
         alert(angular.toJson($scope.listaMedicamentosxPedido));*/
        //$scope.newMedxPedido = { NoFactura:  , CodigoMedicamento: , Cantidad: }
    };

    $scope.addMedRec = function (cant, codMed, nomMed, costo) {
        $scope.medActual = nomMed;
        listaMedsActualesRecs.push({ Nombre: nomMed, Cantidad: cant, Costo: costo });
        listaMedsActuales.push({ NoFactura: "", CodigoMedicamento: codMed, Cantidad: cant, NoSucursal: "" });
        //listaMedsActualesRecs = [];

        //alert(angular.toJson(listaMedsActuales));
        //Prueba que sirvio-----------------
        /* $scope.newMedxPedido = $scope.plantillaPedido;
         $scope.newMedxPedido.codMed = codMed;
         $scope.listaMedicamentosxPedido.push($scope.newMedxPedido);
         alert(angular.toJson($scope.listaMedicamentosxPedido));
         $scope.listaMedicamentosxPedido[0].NoFactura = 3;
         alert(angular.toJson($scope.listaMedicamentosxPedido));*/

        //$scope.newMedxPedido = { NoFactura:  , CodigoMedicamento: , Cantidad: }
    };

    $scope.addReceta = function () {
        listaMedicamentosxReceta.push(listaMedsActuales);
        listaMedsActuales = [];
        listaMedsActualesRecs = [];
        listaRecets.push({ NoFactura: "", IdCliente: clienteActual, NoDoctor: $scope.numeroDoc });
        $location.path('/Item/addPedidosView');
    }

    $scope.goAddReceta = function (index) {
        $location.path('/Item/addReceta');
    }

    $scope.addDoc = function (numeroDoc, nombreDoc) {
        $scope.docActual = nombreDoc;
        $scope.numeroDoc = numeroDoc;
        //$scope.data = httpService.query();
        //$scope.Item = pedidosResource.query();
        //$location.path(typeOfView + "/" +index);
    }
    $scope.refresh = function () {
        //$scope.data = httpService.query();
        //$scope.Item = pedidosResource.query();
        //$location.path(typeOfView + "/" +index);
    }
    $scope.cancelar = function () {
        $location.path("/DrPhischel/DoctorMenu");
    }

    $scope.refreshsss = function () {
        $window.location.reload();
    }

    $scope.backPed = function () {
        $location.path('/Item/addPedidosView');
    }

    $scope.borrarMedPed = function (index) {
        listaMedsActualesPeds.splice(index, 1);
        listaMedicamentosxPedido.splice(index, 1);
        $location.path('/Item/addPedidosView');
    }
    $scope.borrarMedRec = function (index) {
        listaMedsActualesRecs.splice(index, 1);
        listaMedsActuales.splice(index, 1);
        $location.path("/Item/addReceta");
    }

    $scope.alerteTermino = function () {
        listaMedicamentosxPedido = [];
        listaMedicamentosxReceta = [];
        listaMedsActualesRecs = [];
        listaMedsActualesPeds = [];
        listaMedsActuales = [];
        listaRecets = [];
        $location.path('/Item/addPedidosView');
        $window.location.reload();
    }

    $scope.addPedido = function (fech, phone, hour) {
        $scope.fechaStandar = "2000-09-30 02:00:11.000"
        pedidoResource.save({
            FechaRecojo: fech, NoSucursal: numSuc, IdCliente: clienteActual, Estado: $scope.Estado, Empresa: $scope.empresaSelec,
            TelefonoPreferido: phone
        }).$promise.then(function (data) {
            $scope.numFac = data.NoFactura;
        })/*.then(function () {
            alert(angular.toJson({ NoFactura: $scope.numFac, IdCliente: clienteActual, NoDoctor: $scope.dochhActual }));
            recetasResource.save({ NoFactura: $scope.numFac, IdCliente: clienteActual, NoDoctor: $scope.dochhActual })
        })*/

        //-----------------------Guardar RECETAS-----------------------------------
         .then(function () {
             listaRecets.push({ NoFactura: $scope.numFac, IdCliente: clienteActual, NoDoctor: $scope.dochhActual });
            //recetasResource.save({ NoFactura: $scope.numFac, IdCliente: clienteActual, NoDoctor: $scope.numeroDoc })
            $scope.recetarioLenght = 1;
            $scope.verifique = true;
            values = listaRecets;
            //alert(angular.toJson(values));
            angular.forEach(values, function (value, key) {
                value.NoFactura = $scope.numFac;
                //alert(angular.toJson(value));
                recetasResource.save(value).$promise.then(function (data) {
                    listaRecets[key].NoReceta = data.NoReceta;

                }).        //-----------------Guardar MEDICAMENTOS por RECETA-------------------------- aqui quede
                    then(function () {
                        medsdeRec = listaMedicamentosxPedido;
                        angular.forEach(medsdeRec, function (medicamento, key2) {
                            medicamento.NoSucursal = numSuc;
                            alert(angular.toJson({
                                CodigoMedicamento: medicamento.CodigoMedicamento, NoReceta: listaRecets[key].NoReceta, Cantidad: medicamento.Cantidad, NoSucursal: medicamento.NoSucursal
                            }));
                            detalleRecetaResource.save({
                                CodigoMedicamento: medicamento.CodigoMedicamento, NoReceta: listaRecets[key].NoReceta, Cantidad: medicamento.Cantidad, NoSucursal: medicamento.NoSucursal
                            });
                        });
                    })
            });
        })
    }
}]);



var prueba = "http://192.168.1.9:8091/api";
angular.module('DrPhischelApp').factory('JsonResource', function ($resource) {
    return $resource(prueba + '/Empleados/:id', {}, {
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





angular.module('DrPhischelApp').factory('doctorResource', function ($resource) {
    return $resource('http://localhost:8080/api/Doctores/:id', {}, {
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

angular.module('DrPhischelApp').factory('telefonosResource', function ($resource) {
    return $resource(prueba  + '/TelefonosClientes/:id', {}, {
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

angular.module('DrPhischelApp').factory('pedidosResource', function ($resource) {
    return $resource(prueba + '/Pedido/:id', {}, {
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

angular.module('DrPhischelApp').factory('recetasResource', function ($resource) {
    return $resource(prueba + '/Recetas/:id', {}, {
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

angular.module('DrPhischelApp').factory('editRecetasResource', function ($resource) {
    return $resource(prueba + '/MedicamentosPorReceta/:cod/:id', {}, {
        query: {
            method: 'GET',
            transformResponse: function (data) {
                return angular.fromJson(data);
            },
            isArray: true
        },
        update: { method: 'PUT' },
        delete: {
            method: 'DELETE',
            headers: { 'Content-Type': 'application/json' }
        }
    });
});


angular.module('DrPhischelApp').factory('casasResource', function ($resource) {
    return $resource(prueba + '/Recetas/:id', {}, {
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

angular.module('DrPhischelApp').factory('medResource', function ($resource) {
    return $resource(prueba + '/Medicamento/:presc/:nosuc/:id', {}, {
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


angular.module('DrPhischelApp').factory('medSucResource', function ($resource) {
    return $resource(prueba + '/MedicamentoEnSucursal/:id/:nosuc/:cant', {}, {
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


angular.module('DrPhischelApp').factory('sucursalResource', function ($resource) {
    return $resource(prueba  + '/Sucursal/:id', {}, {
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


angular.module('DrPhischelApp').factory('pedidoResource', function ($resource) {
    return $resource(prueba +'/Pedido/:id', {}, {
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





angular.module('DrPhischelApp').factory('detallePedidoResource', function ($resource) {
    return $resource(prueba +  '/MedicamentosPorPedido/:id', {}, {
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





angular.module('DrPhischelApp').factory('detalleRecetaResource', function ($resource) {
    return $resource(prueba + '/MedicamentosPorReceta/:id', {}, {
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

angular.module('DrPhischelApp').factory('pedidoRecetaResource', function ($resource) {
    return $resource(prueba + '/RecetasPorPedido/:id', {}, {
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
