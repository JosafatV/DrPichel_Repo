angular.module('DrPhischelApp').controller("addPedidoController", ["$scope", "$location", "$window", "$routeParams", "doctorResource", "sucursalResource", "medResource", "pedidoResource", "telefonosResource",
    "JsonResource", "detallePedidoResource", "detalleRecetaResource", "recetasResource", "detalleRecetaResource",

function ($scope, $location, $window, $routeParams, doctorResource, sucursalResource, medResource, pedidoResource, telefonosResource, JsonResource, detallePedidoResource
    , detalleRecetaResource, recetasResource, detalleRecetaResource) {
    //Este es el nuevo---------------------
    //Recordar cambiar clienteActual !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1111
    JsonResource.query().$promise.then(function (data) {
        //$scope.Item = data[parseInt($routeParams.index)];
        $scope.telefonos = telefonosResource.query({ id: clienteActual });
        //$scope.isArray = data instanceof Array;
    });
    $scope.empSelected = empSelected;
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
        $location.path("/Item/clientLog");
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
        }).then(function () {
            //------------------------Guardar  MEDICAMENTOS por PEDIDO---------------------------------------
            var values = listaMedicamentosxPedido;
            angular.forEach(values, function (value, key) {
                value.NoFactura = $scope.numFac;
                value.NoSucursal = numSuc;
                //alert(angular.toJson(value));
                detallePedidoResource.save(value);
            });
        })

        //-----------------------Guardar RECETAS-----------------------------------
        .then(function () {
            $scope.recetarioLenght = listaRecets.length;
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
                        medsdeRec = listaMedicamentosxReceta[key];
                        angular.forEach(medsdeRec, function (medicamento, key2) {
                            medicamento.NoSucursal = numSuc;
                            detalleRecetaResource.save({
                                CodigoMedicamento: medicamento.CodigoMedicamento, NoReceta: listaRecets[key].NoReceta, Cantidad: medicamento.Cantidad, NoSucursal: medicamento.NoSucursal
                            });
                        });
                    })
            });
        })
    }
}]);
