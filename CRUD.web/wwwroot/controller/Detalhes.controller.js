sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel"
], function (Controller, JSONModel) {
    const api = "https://localhost:7134/api/Peca";

    return Controller.extend("AutoPecas.controller.Detalhes", {
        onInit: function () {
            debugger
            let oRouter = this.getOwnerComponent().getRouter();
            oRouter.getRoute("detalhes").attachPatternMatched(this._aoCoincidirRota, this);
        },

        _aoCoincidirRota: function (oEvent) {
            debugger
            let idPeca = oEvent.getParameter("arguments").id;
            this._carregarPeca(idPeca);
        },

        _carregarPeca: function (idPeca) {
            debugger
            fetch(`${api}/${idPeca}`)
                .then(response => response.json())
                .then(json => {
                    var oModel = new JSONModel(json);
                    this.getView().setModel(oModel, "peca");
                })
        },

    });
});