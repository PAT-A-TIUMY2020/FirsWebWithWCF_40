﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace FirsWebWithWCF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add", ReplyAction="http://tempuri.org/IService1/addResponse")]
        double add(double num1, double numb2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add", ReplyAction="http://tempuri.org/IService1/addResponse")]
        System.Threading.Tasks.Task<double> addAsync(double num1, double numb2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sub", ReplyAction="http://tempuri.org/IService1/subResponse")]
        double sub(double num1, double numb2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sub", ReplyAction="http://tempuri.org/IService1/subResponse")]
        System.Threading.Tasks.Task<double> subAsync(double num1, double numb2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multipli", ReplyAction="http://tempuri.org/IService1/MultipliResponse")]
        double Multipli(double num1, double numb2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multipli", ReplyAction="http://tempuri.org/IService1/MultipliResponse")]
        System.Threading.Tasks.Task<double> MultipliAsync(double num1, double numb2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Divide", ReplyAction="http://tempuri.org/IService1/DivideResponse")]
        double Divide(double num1, double numb2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Divide", ReplyAction="http://tempuri.org/IService1/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double num1, double numb2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : FirsWebWithWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<FirsWebWithWCF.ServiceReference1.IService1>, FirsWebWithWCF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double add(double num1, double numb2) {
            return base.Channel.add(num1, numb2);
        }
        
        public System.Threading.Tasks.Task<double> addAsync(double num1, double numb2) {
            return base.Channel.addAsync(num1, numb2);
        }
        
        public double sub(double num1, double numb2) {
            return base.Channel.sub(num1, numb2);
        }
        
        public System.Threading.Tasks.Task<double> subAsync(double num1, double numb2) {
            return base.Channel.subAsync(num1, numb2);
        }
        
        public double Multipli(double num1, double numb2) {
            return base.Channel.Multipli(num1, numb2);
        }
        
        public System.Threading.Tasks.Task<double> MultipliAsync(double num1, double numb2) {
            return base.Channel.MultipliAsync(num1, numb2);
        }
        
        public double Divide(double num1, double numb2) {
            return base.Channel.Divide(num1, numb2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double num1, double numb2) {
            return base.Channel.DivideAsync(num1, numb2);
        }

		internal object Sub(double v1, double v2)
		{
			throw new NotImplementedException();
		}
	}
}
