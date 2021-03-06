#pragma warning disable
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Csla.WcfPortal {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CriteriaRequest", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Mobile")]
    [System.SerializableAttribute()]
    public partial class CriteriaRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ClientContextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientCultureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientUICultureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] CriteriaDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] GlobalContextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PrincipalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ClientContext {
            get {
                return this.ClientContextField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientContextField, value) != true)) {
                    this.ClientContextField = value;
                    this.RaisePropertyChanged("ClientContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientCulture {
            get {
                return this.ClientCultureField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientCultureField, value) != true)) {
                    this.ClientCultureField = value;
                    this.RaisePropertyChanged("ClientCulture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientUICulture {
            get {
                return this.ClientUICultureField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientUICultureField, value) != true)) {
                    this.ClientUICultureField = value;
                    this.RaisePropertyChanged("ClientUICulture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] CriteriaData {
            get {
                return this.CriteriaDataField;
            }
            set {
                if ((object.ReferenceEquals(this.CriteriaDataField, value) != true)) {
                    this.CriteriaDataField = value;
                    this.RaisePropertyChanged("CriteriaData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] GlobalContext {
            get {
                return this.GlobalContextField;
            }
            set {
                if ((object.ReferenceEquals(this.GlobalContextField, value) != true)) {
                    this.GlobalContextField = value;
                    this.RaisePropertyChanged("GlobalContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Principal {
            get {
                return this.PrincipalField;
            }
            set {
                if ((object.ReferenceEquals(this.PrincipalField, value) != true)) {
                    this.PrincipalField = value;
                    this.RaisePropertyChanged("Principal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName {
            get {
                return this.TypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNameField, value) != true)) {
                    this.TypeNameField = value;
                    this.RaisePropertyChanged("TypeName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WcfResponse", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Mobile")]
    [System.SerializableAttribute()]
    public partial class WcfResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Csla.WcfPortal.WcfErrorInfo ErrorDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] GlobalContextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ObjectDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Csla.WcfPortal.WcfErrorInfo ErrorData {
            get {
                return this.ErrorDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDataField, value) != true)) {
                    this.ErrorDataField = value;
                    this.RaisePropertyChanged("ErrorData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] GlobalContext {
            get {
                return this.GlobalContextField;
            }
            set {
                if ((object.ReferenceEquals(this.GlobalContextField, value) != true)) {
                    this.GlobalContextField = value;
                    this.RaisePropertyChanged("GlobalContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ObjectData {
            get {
                return this.ObjectDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectDataField, value) != true)) {
                    this.ObjectDataField = value;
                    this.RaisePropertyChanged("ObjectData");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WcfErrorInfo", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Mobile")]
    [System.SerializableAttribute()]
    public partial class WcfErrorInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionTypeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Csla.WcfPortal.WcfErrorInfo InnerErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TargetSiteNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExceptionTypeName {
            get {
                return this.ExceptionTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionTypeNameField, value) != true)) {
                    this.ExceptionTypeNameField = value;
                    this.RaisePropertyChanged("ExceptionTypeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Csla.WcfPortal.WcfErrorInfo InnerError {
            get {
                return this.InnerErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.InnerErrorField, value) != true)) {
                    this.InnerErrorField = value;
                    this.RaisePropertyChanged("InnerError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source {
            get {
                return this.SourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceField, value) != true)) {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TargetSiteName {
            get {
                return this.TargetSiteNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TargetSiteNameField, value) != true)) {
                    this.TargetSiteNameField = value;
                    this.RaisePropertyChanged("TargetSiteName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateRequest", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Mobile")]
    [System.SerializableAttribute()]
    public partial class UpdateRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ClientContextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientCultureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientUICultureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] GlobalContextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ObjectDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PrincipalField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ClientContext {
            get {
                return this.ClientContextField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientContextField, value) != true)) {
                    this.ClientContextField = value;
                    this.RaisePropertyChanged("ClientContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientCulture {
            get {
                return this.ClientCultureField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientCultureField, value) != true)) {
                    this.ClientCultureField = value;
                    this.RaisePropertyChanged("ClientCulture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientUICulture {
            get {
                return this.ClientUICultureField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientUICultureField, value) != true)) {
                    this.ClientUICultureField = value;
                    this.RaisePropertyChanged("ClientUICulture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] GlobalContext {
            get {
                return this.GlobalContextField;
            }
            set {
                if ((object.ReferenceEquals(this.GlobalContextField, value) != true)) {
                    this.GlobalContextField = value;
                    this.RaisePropertyChanged("GlobalContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ObjectData {
            get {
                return this.ObjectDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectDataField, value) != true)) {
                    this.ObjectDataField = value;
                    this.RaisePropertyChanged("ObjectData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Principal {
            get {
                return this.PrincipalField;
            }
            set {
                if ((object.ReferenceEquals(this.PrincipalField, value) != true)) {
                    this.PrincipalField = value;
                    this.RaisePropertyChanged("Principal");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.lhotka.net/WcfDataPortal", ConfigurationName="WcfPortal.IWcfPortal")]
    public interface IWcfPortal {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Create", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/CreateResponse")]
        Csla.WcfPortal.WcfResponse Create(Csla.WcfPortal.CriteriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Create", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/CreateResponse")]
        System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> CreateAsync(Csla.WcfPortal.CriteriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Fetch", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/FetchResponse")]
        Csla.WcfPortal.WcfResponse Fetch(Csla.WcfPortal.CriteriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Fetch", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/FetchResponse")]
        System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> FetchAsync(Csla.WcfPortal.CriteriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Update", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/UpdateResponse")]
        Csla.WcfPortal.WcfResponse Update(Csla.WcfPortal.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Update", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/UpdateResponse")]
        System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> UpdateAsync(Csla.WcfPortal.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Delete", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/DeleteResponse")]
        Csla.WcfPortal.WcfResponse Delete(Csla.WcfPortal.CriteriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Delete", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/DeleteResponse")]
        System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> DeleteAsync(Csla.WcfPortal.CriteriaRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfPortalChannel : Csla.WcfPortal.IWcfPortal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfPortalClient : System.ServiceModel.ClientBase<Csla.WcfPortal.IWcfPortal>, Csla.WcfPortal.IWcfPortal {
        
        public WcfPortalClient() {
        }
        
        public WcfPortalClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfPortalClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfPortalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfPortalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Csla.WcfPortal.WcfResponse Create(Csla.WcfPortal.CriteriaRequest request) {
            return base.Channel.Create(request);
        }
        
        public System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> CreateAsync(Csla.WcfPortal.CriteriaRequest request) {
            return base.Channel.CreateAsync(request);
        }
        
        public Csla.WcfPortal.WcfResponse Fetch(Csla.WcfPortal.CriteriaRequest request) {
            return base.Channel.Fetch(request);
        }
        
        public System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> FetchAsync(Csla.WcfPortal.CriteriaRequest request) {
            return base.Channel.FetchAsync(request);
        }
        
        public Csla.WcfPortal.WcfResponse Update(Csla.WcfPortal.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> UpdateAsync(Csla.WcfPortal.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public Csla.WcfPortal.WcfResponse Delete(Csla.WcfPortal.CriteriaRequest request) {
            return base.Channel.Delete(request);
        }
        
        public System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> DeleteAsync(Csla.WcfPortal.CriteriaRequest request) {
            return base.Channel.DeleteAsync(request);
        }
    }
}
