var fCVE_TipoLugar = function (command, record) {
    v_accion = 0;
    if (command = 'btEditar')
        v_accion = 2;
    else
        v_accion = 3;
    App.direct.fCVE_TipoLugar(v_accion, record.data.idlu_tipo, record.data.nombre);

},
fCeVE_TipoLugar = function(){
    parent.App.Win_EditarTipoLugar.close();
}