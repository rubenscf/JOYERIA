var eventoSeleccionado = 0;
var addTab = function (tabPanel, id, url, title, menuItem) {
    var tab = tabPanel.getComponent(id);

    if (!tab) {
        tab = tabPanel.add({
            id: id,
            title: title,
            closable: true,
            menuItem: menuItem,
            loader: {
                url: url,
                renderer: "frame",
                loadMask: {
                    showMask: true,
                    msg: "Cargando " + title + "..."
                }
            }
        });

    }

    tabPanel.setActiveTab(tab);
},

mostrarInfoPorEvento = function (id) {
    obtenerIdSeleccionado(id);
};
