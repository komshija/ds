﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Korisnik.PrijavaServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PrijavaServiceReference.IPrijava")]
    public interface IPrijava {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrijava/PrijaviSe", ReplyAction="http://tempuri.org/IPrijava/PrijaviSeResponse")]
        bool PrijaviSe(string ime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrijava/PrijaviSe", ReplyAction="http://tempuri.org/IPrijava/PrijaviSeResponse")]
        System.Threading.Tasks.Task<bool> PrijaviSeAsync(string ime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrijava/OdjaviSe", ReplyAction="http://tempuri.org/IPrijava/OdjaviSeResponse")]
        bool OdjaviSe(string ime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrijava/OdjaviSe", ReplyAction="http://tempuri.org/IPrijava/OdjaviSeResponse")]
        System.Threading.Tasks.Task<bool> OdjaviSeAsync(string ime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrijava/VratiProvedenoVreme", ReplyAction="http://tempuri.org/IPrijava/VratiProvedenoVremeResponse")]
        System.Collections.Generic.List<string> VratiProvedenoVreme(string ime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrijava/VratiProvedenoVreme", ReplyAction="http://tempuri.org/IPrijava/VratiProvedenoVremeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> VratiProvedenoVremeAsync(string ime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrijava/VratiSve", ReplyAction="http://tempuri.org/IPrijava/VratiSveResponse")]
        System.Collections.Generic.List<string> VratiSve();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrijava/VratiSve", ReplyAction="http://tempuri.org/IPrijava/VratiSveResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> VratiSveAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrijavaChannel : Korisnik.PrijavaServiceReference.IPrijava, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrijavaClient : System.ServiceModel.ClientBase<Korisnik.PrijavaServiceReference.IPrijava>, Korisnik.PrijavaServiceReference.IPrijava {
        
        public PrijavaClient() {
        }
        
        public PrijavaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrijavaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrijavaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrijavaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool PrijaviSe(string ime) {
            return base.Channel.PrijaviSe(ime);
        }
        
        public System.Threading.Tasks.Task<bool> PrijaviSeAsync(string ime) {
            return base.Channel.PrijaviSeAsync(ime);
        }
        
        public bool OdjaviSe(string ime) {
            return base.Channel.OdjaviSe(ime);
        }
        
        public System.Threading.Tasks.Task<bool> OdjaviSeAsync(string ime) {
            return base.Channel.OdjaviSeAsync(ime);
        }
        
        public System.Collections.Generic.List<string> VratiProvedenoVreme(string ime) {
            return base.Channel.VratiProvedenoVreme(ime);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> VratiProvedenoVremeAsync(string ime) {
            return base.Channel.VratiProvedenoVremeAsync(ime);
        }
        
        public System.Collections.Generic.List<string> VratiSve() {
            return base.Channel.VratiSve();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> VratiSveAsync() {
            return base.Channel.VratiSveAsync();
        }
    }
}