﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServer")]
    public interface IServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServer/GetAuthors", ReplyAction="http://tempuri.org/IServer/GetAuthorsResponse")]
        string[] GetAuthors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServer/DeTai", ReplyAction="http://tempuri.org/IServer/DeTaiResponse")]
        string DeTai();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServerChannel : Client.ServiceReference1.IServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IServer>, Client.ServiceReference1.IServer {
        
        public ServerClient() {
        }
        
        public ServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetAuthors() {
            return base.Channel.GetAuthors();
        }
        
        public string DeTai() {
            return base.Channel.DeTai();
        }
    }
}
