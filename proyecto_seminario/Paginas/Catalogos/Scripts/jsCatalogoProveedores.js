var fLlenarGrid = function () {
    App.direct.fLlenarGrid();
},

fCrearVentanaProveedor = function (command, record) {
    if (command == 'editarProveedor')
        App.direct.fcrearVentanaProveedor(2, record.data.idproveedor);
    else
        App.direct.fcrearVentanaProveedor(1, 0);
},
fGuardar = function () {
    App.direct.fGuardar(
        {
            success: function (result) {
                if (result == 1) {
                    msgBox_A('EXITOSO!!!', 'El Registro fue Guardado!');
                } else if (result == 2) {
                    msgBox_A('EXITOSO!!!', 'El Registro fue Modificado!');
                } else if (result == 3) {
                    msgBox_A('EXITOSO!!!', 'El Registro fue Eliminado!');
                } else {
                    msgBox_B('ERROR!!!', 'El Registro no fue procesado!');
                };
            }
        });
},

msgBox_A = function (titulo, texto) {
    Ext.MessageBox.show({
        title: titulo,
        msg: texto,
        width: 300,
        buttons: Ext.MessageBox.OK,
        fn: fCerrarVentanaProveedor,
        icon: Ext.MessageBox.OK
    });
},

msgBox_B = function (titulo, texto) {
    Ext.MessageBox.show({
        title: titulo,
        msg: texto,
        width: 300,
        buttons: Ext.MessageBox.OK,
        icon: Ext.MessageBox.OK
    });
},

fCerrarVentanaProveedor = function () {
    parent.App.direct.fLlenarGrid();
    parent.App.Win_EditarProveedor.close();
   
},
////
Filtrar = function () {
    var store = App.dg.getStore();
    store.filterBy(ObtenerFiltro());
},
ObtenerFiltro = function () {
    var f = [];

    f.push({
        filter: function (record) {
            return filtrarCadena(App.FiltroProveedor.value || "", "emp_nombre", record);
        }
    });

    var len = f.length;

    return function (record) {
        for (var i = 0; i < len; i++) {
            if (!f[i].filter(record)) {
                return false;
            }
        }
        return true;
    };
},
filtrarCadena = function (value, dataIndex, record) {
    var val = record.get(dataIndex);

    if (typeof val != "string") {
        return value.length == 0;
    }

    return val.toLowerCase().indexOf(value.toLowerCase()) > -1;
};