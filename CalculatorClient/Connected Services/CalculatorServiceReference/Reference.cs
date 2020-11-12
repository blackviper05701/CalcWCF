﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorClient.CalculatorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorServiceReference.ICalcutorService")]
    public interface ICalcutorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcutorService/Add", ReplyAction="http://tempuri.org/ICalcutorService/AddResponse")]
        double Add(int[] numbers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcutorService/Add", ReplyAction="http://tempuri.org/ICalcutorService/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(int[] numbers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcutorService/Multifly", ReplyAction="http://tempuri.org/ICalcutorService/MultiflyResponse")]
        double Multifly(int[] numbers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcutorService/Multifly", ReplyAction="http://tempuri.org/ICalcutorService/MultiflyResponse")]
        System.Threading.Tasks.Task<double> MultiflyAsync(int[] numbers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcutorServiceChannel : CalculatorClient.CalculatorServiceReference.ICalcutorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcutorServiceClient : System.ServiceModel.ClientBase<CalculatorClient.CalculatorServiceReference.ICalcutorService>, CalculatorClient.CalculatorServiceReference.ICalcutorService {
        
        public CalcutorServiceClient() {
        }
        
        public CalcutorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcutorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcutorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcutorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(int[] numbers) {
            return base.Channel.Add(numbers);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(int[] numbers) {
            return base.Channel.AddAsync(numbers);
        }
        
        public double Multifly(int[] numbers) {
            return base.Channel.Multifly(numbers);
        }
        
        public System.Threading.Tasks.Task<double> MultiflyAsync(int[] numbers) {
            return base.Channel.MultiflyAsync(numbers);
        }
    }
}