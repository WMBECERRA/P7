﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Logica.servicioTienda {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceVentasSoap", Namespace="http://tempuri.org/")]
    public partial class WebServiceVentas : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ListarProductosOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarXIdOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebServiceVentas() {
            this.Url = global::Logica.Properties.Settings.Default.Logica_servicioTienda_WebServiceVentas;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ListarProductosCompletedEventHandler ListarProductosCompleted;
        
        /// <remarks/>
        public event BuscarXIdCompletedEventHandler BuscarXIdCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarProductos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Producto[] ListarProductos() {
            object[] results = this.Invoke("ListarProductos", new object[0]);
            return ((Producto[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarProductosAsync() {
            this.ListarProductosAsync(null);
        }
        
        /// <remarks/>
        public void ListarProductosAsync(object userState) {
            if ((this.ListarProductosOperationCompleted == null)) {
                this.ListarProductosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarProductosOperationCompleted);
            }
            this.InvokeAsync("ListarProductos", new object[0], this.ListarProductosOperationCompleted, userState);
        }
        
        private void OnListarProductosOperationCompleted(object arg) {
            if ((this.ListarProductosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarProductosCompleted(this, new ListarProductosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarXId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Producto BuscarXId(int id) {
            object[] results = this.Invoke("BuscarXId", new object[] {
                        id});
            return ((Producto)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarXIdAsync(int id) {
            this.BuscarXIdAsync(id, null);
        }
        
        /// <remarks/>
        public void BuscarXIdAsync(int id, object userState) {
            if ((this.BuscarXIdOperationCompleted == null)) {
                this.BuscarXIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarXIdOperationCompleted);
            }
            this.InvokeAsync("BuscarXId", new object[] {
                        id}, this.BuscarXIdOperationCompleted, userState);
        }
        
        private void OnBuscarXIdOperationCompleted(object arg) {
            if ((this.BuscarXIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarXIdCompleted(this, new BuscarXIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Producto {
        
        private int idProductoField;
        
        private string nombreField;
        
        private decimal precio_unitarioField;
        
        private byte ivaField;
        
        /// <remarks/>
        public int idProducto {
            get {
                return this.idProductoField;
            }
            set {
                this.idProductoField = value;
            }
        }
        
        /// <remarks/>
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        public decimal precio_unitario {
            get {
                return this.precio_unitarioField;
            }
            set {
                this.precio_unitarioField = value;
            }
        }
        
        /// <remarks/>
        public byte iva {
            get {
                return this.ivaField;
            }
            set {
                this.ivaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void ListarProductosCompletedEventHandler(object sender, ListarProductosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarProductosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarProductosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Producto[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Producto[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void BuscarXIdCompletedEventHandler(object sender, BuscarXIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarXIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarXIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Producto Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Producto)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591