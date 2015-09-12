var fLlenarGrid = function () {
    App.direct.fLlenarGrid();
},
fCrearVentanaProveedor = function (command, record) {
    if (command == 'editarProveedor')
        App.direct.fcrearVentanaProveedor(2, record.data.idproveedor);
    else
        App.direct.fcrearVentanaProveedor(1, 0);
},
fGuardar = function(){
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
                    msgBoxB('EXITOSO!!!', 'El Registro fue Eliminado!');
                } else {
                    msgBoxA('ERROR!!!', 'El Registro no fue procesado!');
                };
            }
        });
},
fCerrarVentanaProveedor = function () {
    parent.App.Win_EditarProveedor.close();
}
