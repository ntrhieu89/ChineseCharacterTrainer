﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace ChineseCharacterTrainer.Implementation.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IChineseCharacterTrainerService")]
    public interface IChineseCharacterTrainerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/GetAll", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/GetAllResponse")]
        System.Collections.Generic.List<ChineseCharacterTrainer.Model.Entity> GetAll(string typeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/Add", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ChineseCharacterTrainer.Model.Dictionary))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ChineseCharacterTrainer.Model.DictionaryEntry))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ChineseCharacterTrainer.Model.Translation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ChineseCharacterTrainer.Model.Highscore))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ChineseCharacterTrainer.Model.User))]
        void Add(string typeName, ChineseCharacterTrainer.Model.Entity entity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChineseCharacterTrainerServiceChannel : ChineseCharacterTrainer.Implementation.ServiceReference.IChineseCharacterTrainerService, System.ServiceModel.IClientChannel {
    }
    
    [ExcludeFromCodeCoverage]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChineseCharacterTrainerServiceClient : System.ServiceModel.ClientBase<ChineseCharacterTrainer.Implementation.ServiceReference.IChineseCharacterTrainerService>, ChineseCharacterTrainer.Implementation.ServiceReference.IChineseCharacterTrainerService {
        
        public ChineseCharacterTrainerServiceClient() {
        }
        
        public ChineseCharacterTrainerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChineseCharacterTrainerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChineseCharacterTrainerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChineseCharacterTrainerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<ChineseCharacterTrainer.Model.Entity> GetAll(string typeName) {
            return base.Channel.GetAll(typeName);
        }
        
        public void Add(string typeName, ChineseCharacterTrainer.Model.Entity entity) {
            base.Channel.Add(typeName, entity);
        }
    }
}
