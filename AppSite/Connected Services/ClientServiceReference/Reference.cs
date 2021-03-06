﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppSite.ClientServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/AppModels.Models")]
    [System.SerializableAttribute()]
    public partial class Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNamesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamesField;
        
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
        public System.DateTime Birth {
            get {
                return this.BirthField;
            }
            set {
                if ((this.BirthField.Equals(value) != true)) {
                    this.BirthField = value;
                    this.RaisePropertyChanged("Birth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocNumber {
            get {
                return this.DocNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.DocNumberField, value) != true)) {
                    this.DocNumberField = value;
                    this.RaisePropertyChanged("DocNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastNames {
            get {
                return this.LastNamesField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNamesField, value) != true)) {
                    this.LastNamesField = value;
                    this.RaisePropertyChanged("LastNames");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Names {
            get {
                return this.NamesField;
            }
            set {
                if ((object.ReferenceEquals(this.NamesField, value) != true)) {
                    this.NamesField = value;
                    this.RaisePropertyChanged("Names");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientServiceReference.IClientService")]
    public interface IClientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetAll", ReplyAction="http://tempuri.org/IClientService/GetAllResponse")]
        AppSite.ClientServiceReference.Client[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetAll", ReplyAction="http://tempuri.org/IClientService/GetAllResponse")]
        System.Threading.Tasks.Task<AppSite.ClientServiceReference.Client[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/Create", ReplyAction="http://tempuri.org/IClientService/CreateResponse")]
        int Create(AppSite.ClientServiceReference.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/Create", ReplyAction="http://tempuri.org/IClientService/CreateResponse")]
        System.Threading.Tasks.Task<int> CreateAsync(AppSite.ClientServiceReference.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/Update", ReplyAction="http://tempuri.org/IClientService/UpdateResponse")]
        int Update(AppSite.ClientServiceReference.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/Update", ReplyAction="http://tempuri.org/IClientService/UpdateResponse")]
        System.Threading.Tasks.Task<int> UpdateAsync(AppSite.ClientServiceReference.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/UpdateActive", ReplyAction="http://tempuri.org/IClientService/UpdateActiveResponse")]
        bool UpdateActive(int clientId, bool isActive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/UpdateActive", ReplyAction="http://tempuri.org/IClientService/UpdateActiveResponse")]
        System.Threading.Tasks.Task<bool> UpdateActiveAsync(int clientId, bool isActive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/Delete", ReplyAction="http://tempuri.org/IClientService/DeleteResponse")]
        bool Delete(int clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/Delete", ReplyAction="http://tempuri.org/IClientService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int clientId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientServiceChannel : AppSite.ClientServiceReference.IClientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientServiceClient : System.ServiceModel.ClientBase<AppSite.ClientServiceReference.IClientService>, AppSite.ClientServiceReference.IClientService {
        
        public ClientServiceClient() {
        }
        
        public ClientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AppSite.ClientServiceReference.Client[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<AppSite.ClientServiceReference.Client[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public int Create(AppSite.ClientServiceReference.Client client) {
            return base.Channel.Create(client);
        }
        
        public System.Threading.Tasks.Task<int> CreateAsync(AppSite.ClientServiceReference.Client client) {
            return base.Channel.CreateAsync(client);
        }
        
        public int Update(AppSite.ClientServiceReference.Client client) {
            return base.Channel.Update(client);
        }
        
        public System.Threading.Tasks.Task<int> UpdateAsync(AppSite.ClientServiceReference.Client client) {
            return base.Channel.UpdateAsync(client);
        }
        
        public bool UpdateActive(int clientId, bool isActive) {
            return base.Channel.UpdateActive(clientId, isActive);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateActiveAsync(int clientId, bool isActive) {
            return base.Channel.UpdateActiveAsync(clientId, isActive);
        }
        
        public bool Delete(int clientId) {
            return base.Channel.Delete(clientId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int clientId) {
            return base.Channel.DeleteAsync(clientId);
        }
    }
}
