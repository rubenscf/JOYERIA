var fLlenarGrid = function () {
    App.direct.fLlenarGrid();
},
fCrearVentanaCuentas = function (command, record) {
    if (command == 'editarCuentas')
        App.direct.fcrearVentanaCuentas(2, record.data.idcuenta);
    else
        App.direct.fcrearVentanaCuentas(1, 0);
},
fGuardar = function () {
    App.direct.fGuardar(
        {
            success: function (result) {
                if (result == 1) {
                    Ext.net.Notification.show({
                        iconCls: 'icon-information',
                        pinEvent: 'click',
                        html: '<h3>Cambio Guardado</h3>'
                    });
                } else if (result == 3) {
                    msgBoxB('Exisitoso!', 'El Registro fue Eliminado!');
                } else {
                    msgBoxA('ERROR!!!', 'El Registro no fue procesado!');
                };
            }
        });
},
fCerrarVentanaCuentas = function () {
    parent.App.Win_EditarCuentas.close();
}