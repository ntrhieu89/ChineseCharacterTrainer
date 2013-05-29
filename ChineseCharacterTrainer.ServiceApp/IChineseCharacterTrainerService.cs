﻿using ChineseCharacterTrainer.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace ChineseCharacterTrainer.ServiceApp
{
    [ServiceContract]
    public interface IChineseCharacterTrainerService
    {
        [OperationContract]
        void AddDictionary(Dictionary dictionary);

        [OperationContract]
        [ApplyDataContractResolver]
        List<Dictionary> GetDictionaries();

        [OperationContract]
        void AddHighscore(Highscore highscore);

        [OperationContract]
        [ApplyDataContractResolver]
        List<Highscore> GetHighscores();
    }
}
