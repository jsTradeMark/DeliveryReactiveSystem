﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drs.ViewModel.LoginSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginSvc.ILoginSvc")]
    public interface ILoginSvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginSvc/Login", ReplyAction="http://tempuri.org/ILoginSvc/LoginResponse")]
        Drs.Model.Shared.ResponseMessage Login([System.ServiceModel.MessageParameterAttribute(Name="login")] Drs.Model.Account.LoginModel login1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginSvc/Login", ReplyAction="http://tempuri.org/ILoginSvc/LoginResponse")]
        System.Threading.Tasks.Task<Drs.Model.Shared.ResponseMessage> LoginAsync(Drs.Model.Account.LoginModel login);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginSvcChannel : Drs.ViewModel.LoginSvc.ILoginSvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginSvcClient : System.ServiceModel.ClientBase<Drs.ViewModel.LoginSvc.ILoginSvc>, Drs.ViewModel.LoginSvc.ILoginSvc {
        
        public LoginSvcClient() {
        }
        
        public LoginSvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginSvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Drs.Model.Shared.ResponseMessage Login(Drs.Model.Account.LoginModel login1) {
            return base.Channel.Login(login1);
        }
        
        public System.Threading.Tasks.Task<Drs.Model.Shared.ResponseMessage> LoginAsync(Drs.Model.Account.LoginModel login) {
            return base.Channel.LoginAsync(login);
        }
    }
}