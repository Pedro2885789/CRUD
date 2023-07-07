sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/ui/model/Filter",
    "sap/ui/model/FilterOperator"
], function (Controller, JSONModel, Filter, FilterOperator) {
    const rotaListaDePecas = "listaDePecas";
    const rotaDetalhes = "detalhes";
    const api = "https://localhost:7134/api/Peca";
    const modeloPecas = "pecas";
    const campoTabela = "pecasDaTabela"


    return Controller.extend("AutoPecas.controller.ListaDePecas", {
        onInit: function () {
            let oRouter = this.getOwnerComponent().getRouter();
            oRouter.getRoute(rotaListaDePecas).attachPatternMatched(this._aoCoincidirRota, this);
        },

        _aoCoincidirRota: function () {
            this._carregaPecas();
        },

        _carregaPecas: function () {
            fetch(api)
                .then(resp => resp.json())
                .then(data => {
                    let oModel = new JSONModel(data);
                    this.getView().setModel(oModel, modeloPecas)
                })
        },

        aoClicarNaLinha: function (oEvent) {
            debugger
            let idPeca = oEvent.getSource().getBindingContext(modeloPecas).getObject().id
            this._navegar(rotaDetalhes, idPeca);
        },

        aoClicarProcurarPeca: function (peca) {
            let aFilter = [];
            let nomePeca = peca.getParameter("newValue");
            if (nomePeca) {
                aFilter.push(new Filter("nome", FilterOperator.Contains, nomePeca));
            }
            let oList = this.byId(campoTabela);
            let oBinding = oList.getBinding("items");
            oBinding.filter(aFilter);
        },

        _navegar: function (rota, id) {
            debugger
            let oRouter = this.getOwnerComponent().getRouter();
            oRouter.navTo(rota, { id });
        },

    });
});
