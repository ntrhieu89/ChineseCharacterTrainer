﻿using System;
using ChineseCharacterTrainer.Implementation.ServiceReference;
using ChineseCharacterTrainer.Implementation.Services;
using ChineseCharacterTrainer.Model;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace ChineseCharacterTrainer.UnitTest.Services
{
    public class RepositoryTest
    {
        private IRepository _objectUnderTest;
        private Mock<IChineseCharacterTrainerService> _serviceMock;

        private readonly Dictionary _dictionary =
            new Dictionary("MyDict",
                           new List<DictionaryEntry>
                               {
                                   new DictionaryEntry("你", "ni3",
                                                       new List<Translation>
                                                           {
                                                               new Translation("you")
                                                           })
                               });

        [SetUp]
        public void Initialize()
        {
            _serviceMock = new Mock<IChineseCharacterTrainerService>();

            _objectUnderTest = new Repository(_serviceMock.Object);
        }

        [Test]
        public void ShouldAddItemToServiceWhenAddingDictionary()
        {
            _objectUnderTest.AddDictionary(_dictionary);

            _serviceMock.Verify(p => p.AddDictionary(_dictionary));
        }

        [Test]
        public void ShouldGetDictionary()
        {
            _serviceMock.Setup(p => p.GetDictionaries()).Returns(new List<Dictionary>
                {
                    new Dictionary("1", null),
                    new Dictionary("2", null)
                });

            var dictionaries = _objectUnderTest.GetAllDictionaries();

            Assert.AreEqual(2, dictionaries.Count);
        }

        [Test]
        public void ShouldAddHighscoreToServiceWhenAddingHighscore()
        {
            var highscore = CreateTestHighscore();

            _objectUnderTest.AddHighscore(highscore);

            _serviceMock.Verify(p => p.AddHighscore(highscore));
        }

        [Test]
        public void ShouldAddQuestionResultAndAnswersWhenAddingQuestionResult()
        {
            var questionResult = new QuestionResult();
            var answer = new Answer(true, DateTime.Now, TimeSpan.FromSeconds(1), null);
            questionResult.AddAnswer(answer);

            _objectUnderTest.AddQuestionResult(questionResult);

            _serviceMock.Verify(p => p.AddQuestionResult(questionResult));
            _serviceMock.Verify(p => p.AddAnswer(answer));
        }

        [Test]
        public void ShouldGetHighscore()
        {
            _serviceMock.Setup(p => p.GetHighscoresForDictionary(_dictionary.Id)).Returns(new List<Highscore>
                {
                    CreateTestHighscore(),
                    CreateTestHighscore()
                });

            var highscores = _objectUnderTest.GetAllHighscores(_dictionary.Id);

            Assert.AreEqual(2, highscores.Count);
        }

        [Test]
        public void ShouldGetDictionaryEntriesForQueryObject()
        {
            _serviceMock.Setup(p => p.GetDictionaryEntriesForQueryObject(It.IsAny<QueryObject>())).Returns(
                new List<DictionaryEntry>(_dictionary.Entries));

            var entries = _objectUnderTest.GetDictionaryEntriesForQueryObject(new QueryObject(new Guid()));

            Assert.AreEqual(_dictionary.Entries, entries);
        }

        private Highscore CreateTestHighscore()
        {
            return new Highscore("Frank", _dictionary.Id, new QuestionResult());
        }
    }
}
