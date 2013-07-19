﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/GetDictionaries", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/GetDictionariesResponse")]
        System.Collections.Generic.List<ChineseCharacterTrainer.Model.Dictionary> GetDictionaries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/GetDictionaryEntriesForDiction" +
            "ary", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/GetDictionaryEntriesForDiction" +
            "aryResponse")]
        System.Collections.Generic.List<ChineseCharacterTrainer.Model.DictionaryEntry> GetDictionaryEntriesForDictionary(System.Guid dictionaryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/GetHighscoresForDictionary", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/GetHighscoresForDictionaryResp" +
            "onse")]
        System.Collections.Generic.List<ChineseCharacterTrainer.Model.Highscore> GetHighscoresForDictionary(System.Guid dictionaryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/GetDictionaryEntriesForQueryOb" +
            "ject", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/GetDictionaryEntriesForQueryOb" +
            "jectResponse")]
        System.Collections.Generic.List<ChineseCharacterTrainer.Model.DictionaryEntry> GetDictionaryEntriesForQueryObject(ChineseCharacterTrainer.Model.QueryObject queryObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/GetQuestionResultById", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/GetQuestionResultByIdResponse")]
        ChineseCharacterTrainer.Model.QuestionResult GetQuestionResultById(System.Guid questionResultId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/AddDictionary", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/AddDictionaryResponse")]
        void AddDictionary(ChineseCharacterTrainer.Model.Dictionary dictionary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/AddDictionaryEntry", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/AddDictionaryEntryResponse")]
        void AddDictionaryEntry(ChineseCharacterTrainer.Model.DictionaryEntry dictionaryEntry);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/AddHighscore", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/AddHighscoreResponse")]
        void AddHighscore(ChineseCharacterTrainer.Model.Highscore highscore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/AddQuestionResult", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/AddQuestionResultResponse")]
        void AddQuestionResult(ChineseCharacterTrainer.Model.QuestionResult questionResult);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChineseCharacterTrainerService/AddAnswer", ReplyAction="http://tempuri.org/IChineseCharacterTrainerService/AddAnswerResponse")]
        void AddAnswer(ChineseCharacterTrainer.Model.Answer answer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChineseCharacterTrainerServiceChannel : ChineseCharacterTrainer.Implementation.ServiceReference.IChineseCharacterTrainerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ExcludeFromCodeCoverage]
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
        
        public System.Collections.Generic.List<ChineseCharacterTrainer.Model.Dictionary> GetDictionaries() {
            return base.Channel.GetDictionaries();
        }
        
        public System.Collections.Generic.List<ChineseCharacterTrainer.Model.DictionaryEntry> GetDictionaryEntriesForDictionary(System.Guid dictionaryId) {
            return base.Channel.GetDictionaryEntriesForDictionary(dictionaryId);
        }
        
        public System.Collections.Generic.List<ChineseCharacterTrainer.Model.Highscore> GetHighscoresForDictionary(System.Guid dictionaryId) {
            return base.Channel.GetHighscoresForDictionary(dictionaryId);
        }
        
        public System.Collections.Generic.List<ChineseCharacterTrainer.Model.DictionaryEntry> GetDictionaryEntriesForQueryObject(ChineseCharacterTrainer.Model.QueryObject queryObject) {
            return base.Channel.GetDictionaryEntriesForQueryObject(queryObject);
        }
        
        public ChineseCharacterTrainer.Model.QuestionResult GetQuestionResultById(System.Guid questionResultId) {
            return base.Channel.GetQuestionResultById(questionResultId);
        }
        
        public void AddDictionary(ChineseCharacterTrainer.Model.Dictionary dictionary) {
            base.Channel.AddDictionary(dictionary);
        }
        
        public void AddDictionaryEntry(ChineseCharacterTrainer.Model.DictionaryEntry dictionaryEntry) {
            base.Channel.AddDictionaryEntry(dictionaryEntry);
        }
        
        public void AddHighscore(ChineseCharacterTrainer.Model.Highscore highscore) {
            base.Channel.AddHighscore(highscore);
        }
        
        public void AddQuestionResult(ChineseCharacterTrainer.Model.QuestionResult questionResult) {
            base.Channel.AddQuestionResult(questionResult);
        }
        
        public void AddAnswer(ChineseCharacterTrainer.Model.Answer answer) {
            base.Channel.AddAnswer(answer);
        }
    }
}
