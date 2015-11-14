﻿var fLlenarGrid = function () {
    App.direct.fLlenarGrid();
},

fcrearVentanaTipoCuenta = function (command, record) {
    if (command == 'EditarTipoCuenta')
        App.direct.fcrearVentanaTipoCuenta(2, record.data.IdTipo_cta);
    else
        App.direct.fcrearVentanaTipoCuenta(1,0);
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
         fn: fcerrarVentanaTipoCuenta, 
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
    
    fcerrarVentanaTipoCuenta = function () {
        parent.App.direct.fLlenarGrid();
        parent.App.Win_EditarTipoCuenta.close();

    };