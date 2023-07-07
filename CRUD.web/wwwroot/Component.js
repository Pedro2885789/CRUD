sap.ui.define([
    "sap/ui/core/UIComponent"
], function (UIComponent) {
    return UIComponent.extend("sap.ui.demo.AutoPecas.webapp.Component", {
        init: function () {
            UIComponent.prototype.init.apply(this, arguments);
            this.getRouter().initialize();
        }
    });
});