var fLlenarGrid = function () {
    App.direct.fLlenarGrid();
},


fGuardar = function () {
    App.direct.fGuardar(
     {
         success: function (result) {
             if (result == 1) {
                 msgBox_A('EXITOSO!!!', 'El Registro fue Guardado!');
                 parent.App.direct.fLlenarGrid();
             } else if (result == 2) {
                 msgBox_A('EXITOSO!!!', 'El Registro fue Modificado!');
                 parent.App.direct.fLlenarGrid();
             } else if (result == 3) {
                 msgBox_A('EXITOSO!!!', 'El Registro fue Eliminado!');
                 parent.App.direct.fLlenarGrid();
             } else {
                 msgBox_B('ERROR!!!', 'El Registro no fue procesado!');
                 parent.App.direct.fLlenarGrid();
             };
         }
     });
},

fEditar = function (editor, e) {
    if (!(e.value === e.originalValue)) {
        App.direct.fModificarParametro(e.record.data.CODIGO, e.record.data.NOMBRE, e.record.data.PORCENTAJE, 
           {
               success: function (result) {
                   if (result == 2) {
                       Ext.net.Notification.show({
                           iconCls: 'icon-information',
                           pinEvent: 'click',
                           html: '<h3>Cambio Guardado</h3>'
                       });
                   } else if (result == 3) {
                       //     msgBoxB('Exisitoso!', 'El Registro fue Eliminado!');
                   } else {
                       //     msgBoxA('ERROR!!!', 'El Registro no fue procesado!');
                   };
               }
           });
    }
},


msgBox_A = function (titulo, texto) {
    Ext.MessageBox.show({
        title: titulo,
        msg: texto,
        width: 300,
        buttons: Ext.MessageBox.OK,
        //fn: fCerrarVentanaCuentas,
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
};
