﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.225
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.225 版自动生成。
// 
#pragma warning disable 1591

namespace Ipedf.App.ServiceFromSAP {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    // CODEGEN: 未处理命名空间“http://schemas.xmlsoap.org/ws/2004/09/policy”中的可选 WSDL 扩展元素“Policy”。
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="binding", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback Zmm00FmScmpurchordgetOperationCompleted;
        
        private System.Threading.SendOrPostCallback Zmm00FmScmsuplansendOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public service() {
            this.Url = global::Ipedf.App.Properties.Settings.Default.App_ServiceFromSAP_service;
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
        public event Zmm00FmScmpurchordgetCompletedEventHandler Zmm00FmScmpurchordgetCompleted;
        
        /// <remarks/>
        public event Zmm00FmScmsuplansendCompletedEventHandler Zmm00FmScmsuplansendCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sap-com:document:sap:soap:functions:mc-style:ZSAPTOSCMWS:Zmm00FmScmpurchordge" +
            "tRequest", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("Zmm00FmScmpurchordgetResponse", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
        public Zmm00FmScmpurchordgetResponse Zmm00FmScmpurchordget([System.Xml.Serialization.XmlElementAttribute("Zmm00FmScmpurchordget", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")] Zmm00FmScmpurchordget Zmm00FmScmpurchordget1) {
            object[] results = this.Invoke("Zmm00FmScmpurchordget", new object[] {
                        Zmm00FmScmpurchordget1});
            return ((Zmm00FmScmpurchordgetResponse)(results[0]));
        }
        
        /// <remarks/>
        public void Zmm00FmScmpurchordgetAsync(Zmm00FmScmpurchordget Zmm00FmScmpurchordget1) {
            this.Zmm00FmScmpurchordgetAsync(Zmm00FmScmpurchordget1, null);
        }
        
        /// <remarks/>
        public void Zmm00FmScmpurchordgetAsync(Zmm00FmScmpurchordget Zmm00FmScmpurchordget1, object userState) {
            if ((this.Zmm00FmScmpurchordgetOperationCompleted == null)) {
                this.Zmm00FmScmpurchordgetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZmm00FmScmpurchordgetOperationCompleted);
            }
            this.InvokeAsync("Zmm00FmScmpurchordget", new object[] {
                        Zmm00FmScmpurchordget1}, this.Zmm00FmScmpurchordgetOperationCompleted, userState);
        }
        
        private void OnZmm00FmScmpurchordgetOperationCompleted(object arg) {
            if ((this.Zmm00FmScmpurchordgetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Zmm00FmScmpurchordgetCompleted(this, new Zmm00FmScmpurchordgetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sap-com:document:sap:soap:functions:mc-style:ZSAPTOSCMWS:Zmm00FmScmsuplansend" +
            "Request", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("Zmm00FmScmsuplansendResponse", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
        public Zmm00FmScmsuplansendResponse Zmm00FmScmsuplansend([System.Xml.Serialization.XmlElementAttribute("Zmm00FmScmsuplansend", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")] Zmm00FmScmsuplansend Zmm00FmScmsuplansend1) {
            object[] results = this.Invoke("Zmm00FmScmsuplansend", new object[] {
                        Zmm00FmScmsuplansend1});
            return ((Zmm00FmScmsuplansendResponse)(results[0]));
        }
        
        /// <remarks/>
        public void Zmm00FmScmsuplansendAsync(Zmm00FmScmsuplansend Zmm00FmScmsuplansend1) {
            this.Zmm00FmScmsuplansendAsync(Zmm00FmScmsuplansend1, null);
        }
        
        /// <remarks/>
        public void Zmm00FmScmsuplansendAsync(Zmm00FmScmsuplansend Zmm00FmScmsuplansend1, object userState) {
            if ((this.Zmm00FmScmsuplansendOperationCompleted == null)) {
                this.Zmm00FmScmsuplansendOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZmm00FmScmsuplansendOperationCompleted);
            }
            this.InvokeAsync("Zmm00FmScmsuplansend", new object[] {
                        Zmm00FmScmsuplansend1}, this.Zmm00FmScmsuplansendOperationCompleted, userState);
        }
        
        private void OnZmm00FmScmsuplansendOperationCompleted(object arg) {
            if ((this.Zmm00FmScmsuplansendCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Zmm00FmScmsuplansendCompleted(this, new Zmm00FmScmsuplansendCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zmm00FmScmpurchordget {
        
        private Zmm00S018 isSelcondField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Zmm00S018 IsSelcond {
            get {
                return this.isSelcondField;
            }
            set {
                this.isSelcondField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zmm00S018 {
        
        private string lifnrField;
        
        private string zbedatlField;
        
        private string zbedathField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lifnr {
            get {
                return this.lifnrField;
            }
            set {
                this.lifnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zbedatl {
            get {
                return this.zbedatlField;
            }
            set {
                this.zbedatlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zbedath {
            get {
                return this.zbedathField;
            }
            set {
                this.zbedathField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zmm00S022 {
        
        private string zgyjhField;
        
        private string mstypField;
        
        private string messField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zgyjh {
            get {
                return this.zgyjhField;
            }
            set {
                this.zgyjhField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Mstyp {
            get {
                return this.mstypField;
            }
            set {
                this.mstypField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Mess {
            get {
                return this.messField;
            }
            set {
                this.messField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zmm00S020 {
        
        private string zgyjhField;
        
        private string ebelnField;
        
        private string ebelpField;
        
        private string matnrField;
        
        private string txz01Field;
        
        private string lifnrField;
        
        private string name1Field;
        
        private string werksField;
        
        private string lgortField;
        
        private string mengeField;
        
        private string meinsField;
        
        private string msehtField;
        
        private string chargField;
        
        private string zhsdatField;
        
        private string zvfdatField;
        
        private string zfphmField;
        
        private string zfpjrField;
        
        private string zfprqField;
        
        private string zpstaField;
        
        private string barcodeField;
        
        private string zupfgField;
        
        private string zbtxtField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zgyjh {
            get {
                return this.zgyjhField;
            }
            set {
                this.zgyjhField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ebeln {
            get {
                return this.ebelnField;
            }
            set {
                this.ebelnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ebelp {
            get {
                return this.ebelpField;
            }
            set {
                this.ebelpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Matnr {
            get {
                return this.matnrField;
            }
            set {
                this.matnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Txz01 {
            get {
                return this.txz01Field;
            }
            set {
                this.txz01Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lifnr {
            get {
                return this.lifnrField;
            }
            set {
                this.lifnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name1 {
            get {
                return this.name1Field;
            }
            set {
                this.name1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Werks {
            get {
                return this.werksField;
            }
            set {
                this.werksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lgort {
            get {
                return this.lgortField;
            }
            set {
                this.lgortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Menge {
            get {
                return this.mengeField;
            }
            set {
                this.mengeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Meins {
            get {
                return this.meinsField;
            }
            set {
                this.meinsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Mseht {
            get {
                return this.msehtField;
            }
            set {
                this.msehtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Charg {
            get {
                return this.chargField;
            }
            set {
                this.chargField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zhsdat {
            get {
                return this.zhsdatField;
            }
            set {
                this.zhsdatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zvfdat {
            get {
                return this.zvfdatField;
            }
            set {
                this.zvfdatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zfphm {
            get {
                return this.zfphmField;
            }
            set {
                this.zfphmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zfpjr {
            get {
                return this.zfpjrField;
            }
            set {
                this.zfpjrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zfprq {
            get {
                return this.zfprqField;
            }
            set {
                this.zfprqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zpsta {
            get {
                return this.zpstaField;
            }
            set {
                this.zpstaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Barcode {
            get {
                return this.barcodeField;
            }
            set {
                this.barcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zupfg {
            get {
                return this.zupfgField;
            }
            set {
                this.zupfgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zbtxt {
            get {
                return this.zbtxtField;
            }
            set {
                this.zbtxtField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zmm00S019 {
        
        private string ebelnField;
        
        private string ebelpField;
        
        private string lifnrField;
        
        private string name1Field;
        
        private string matnrField;
        
        private string txz01Field;
        
        private string werksField;
        
        private string werkstField;
        
        private string lgortField;
        
        private decimal mengeField;
        
        private string meinsField;
        
        private string msehtField;
        
        private string netprField;
        
        private string eindtField;
        
        private string bedatField;
        
        private string remarkField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ebeln {
            get {
                return this.ebelnField;
            }
            set {
                this.ebelnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ebelp {
            get {
                return this.ebelpField;
            }
            set {
                this.ebelpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lifnr {
            get {
                return this.lifnrField;
            }
            set {
                this.lifnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name1 {
            get {
                return this.name1Field;
            }
            set {
                this.name1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Matnr {
            get {
                return this.matnrField;
            }
            set {
                this.matnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Txz01 {
            get {
                return this.txz01Field;
            }
            set {
                this.txz01Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Werks {
            get {
                return this.werksField;
            }
            set {
                this.werksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Werkst {
            get {
                return this.werkstField;
            }
            set {
                this.werkstField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lgort {
            get {
                return this.lgortField;
            }
            set {
                this.lgortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Menge {
            get {
                return this.mengeField;
            }
            set {
                this.mengeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Meins {
            get {
                return this.meinsField;
            }
            set {
                this.meinsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Mseht {
            get {
                return this.msehtField;
            }
            set {
                this.msehtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Netpr {
            get {
                return this.netprField;
            }
            set {
                this.netprField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Eindt {
            get {
                return this.eindtField;
            }
            set {
                this.eindtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Bedat {
            get {
                return this.bedatField;
            }
            set {
                this.bedatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Remark {
            get {
                return this.remarkField;
            }
            set {
                this.remarkField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zmm00FmScmpurchordgetResponse {
        
        private Zmm00S019[] otPurchinfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zmm00S019[] OtPurchinfo {
            get {
                return this.otPurchinfoField;
            }
            set {
                this.otPurchinfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zmm00FmScmsuplansend {
        
        private Zmm00S020[] itSuplanField;
        
        private Zmm00S022[] otReturnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zmm00S020[] ItSuplan {
            get {
                return this.itSuplanField;
            }
            set {
                this.itSuplanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zmm00S022[] OtReturn {
            get {
                return this.otReturnField;
            }
            set {
                this.otReturnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zmm00FmScmsuplansendResponse {
        
        private Zmm00S020[] itSuplanField;
        
        private Zmm00S022[] otReturnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zmm00S020[] ItSuplan {
            get {
                return this.itSuplanField;
            }
            set {
                this.itSuplanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zmm00S022[] OtReturn {
            get {
                return this.otReturnField;
            }
            set {
                this.otReturnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void Zmm00FmScmpurchordgetCompletedEventHandler(object sender, Zmm00FmScmpurchordgetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Zmm00FmScmpurchordgetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Zmm00FmScmpurchordgetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Zmm00FmScmpurchordgetResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Zmm00FmScmpurchordgetResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void Zmm00FmScmsuplansendCompletedEventHandler(object sender, Zmm00FmScmsuplansendCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Zmm00FmScmsuplansendCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Zmm00FmScmsuplansendCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Zmm00FmScmsuplansendResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Zmm00FmScmsuplansendResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591