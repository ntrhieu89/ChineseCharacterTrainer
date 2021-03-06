﻿using ChineseCharacterTrainer.Implementation.ViewModels;
using ChineseCharacterTrainer.Model;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace ChineseCharacterTrainer.UnitTest.ViewModels
{
    public class MainWindowVMTest
    {
        private IMainWindowVM _objectUnderTest;
        private Mock<IQuestionVM> _questionVMMock;
        private Mock<ICompetitionSummaryVM> _competitionSummaryVMMock;
        private Mock<IPracticeSummaryVM> _practiceSummaryVMMock;
        private Mock<IMenuVM> _menuVMMock;
        private Mock<IHighscoreVM> _highscoreVMMock;

        [SetUp]
        public void Initialize()
        {
            _menuVMMock = new Mock<IMenuVM>();
            _questionVMMock = new Mock<IQuestionVM>();
            _competitionSummaryVMMock = new Mock<ICompetitionSummaryVM>();
            _practiceSummaryVMMock = new Mock<IPracticeSummaryVM>();
            _highscoreVMMock = new Mock<IHighscoreVM>();

            _objectUnderTest = new MainWindowVM(
                _menuVMMock.Object,
                _questionVMMock.Object,
                _competitionSummaryVMMock.Object,
                _practiceSummaryVMMock.Object,
                _highscoreVMMock.Object);
        }

        [Test]
        public void ShouldSetContentToMenuViewModelInConstructor()
        {
            Assert.AreEqual(_menuVMMock.Object, _objectUnderTest.Content);
        }

        [Test]
        public void ShouldSetContentToSummaryViewModelWhenQuestionsAreFinishedAfterCompetition()
        {
            RaiseStartCompetitionEvent();

            _questionVMMock.Raise(p => p.QuestionsFinished += null, new QuestionResult());

            Assert.AreEqual(_competitionSummaryVMMock.Object, _objectUnderTest.Content);
        }

        [Test]
        public void ShouldSetContentToSummaryViewModelWhenQuestionsAreFinishedAfterPractice()
        {
            var dictionaryEntries = new List<DictionaryEntry> { new DictionaryEntry(null, null, null) };
            _menuVMMock.Raise(p => p.StartPracticeRequested += null, dictionaryEntries);

            _questionVMMock.Raise(p => p.QuestionsFinished += null, new QuestionResult());

            Assert.AreEqual(_practiceSummaryVMMock.Object, _objectUnderTest.Content);
        }

        [Test]
        public void ShouldInitializeSummaryViewModelWhenQuestionsAreFinished()
        {
            var selectedDictionary = new Dictionary("Test", null);
            RaiseStartCompetitionEvent();
            _menuVMMock.Setup(p => p.SelectedDictionary).Returns(selectedDictionary);
            var questionResult = new QuestionResult();

            _questionVMMock.Raise(p => p.QuestionsFinished += null, questionResult);

            _competitionSummaryVMMock.Verify(p => p.Initialize(_menuVMMock.Object.SelectedDictionary, questionResult),
                                             Times.Once());
        }

        [Test]
        public void ShouldInitializeQuestionVMWhenDictionaryOpenIsRequested()
        {
            var entries = RaiseStartCompetitionEvent();

            _questionVMMock.Verify(p => p.Initialize(entries));
        }

        [Test]
        public void ShouldStartQuestionsWhenCompetitionIsRequested()
        {
            RaiseStartCompetitionEvent();

            Assert.AreEqual(_questionVMMock.Object, _objectUnderTest.Content);
        }

        [Test]
        public void ShouldStartQuestionsWhenPracticeIsRequested()
        {
            var dictionaryEntries = new List<DictionaryEntry> {new DictionaryEntry(null, null, null)};

            _menuVMMock.Raise(p => p.StartPracticeRequested += null, dictionaryEntries);

            Assert.AreEqual(_questionVMMock.Object, _objectUnderTest.Content);
        }

        [Test]
        public void ShouldShowHighscoreWhenUploadFinishedIsRaised()
        {
            _objectUnderTest.Content = null;

            _competitionSummaryVMMock.Raise(p => p.UploadFinished += null,
                                 new Highscore("Frank", new Dictionary("Dict", null).Id, new QuestionResult()));

            Assert.AreEqual(_objectUnderTest.Content, _highscoreVMMock.Object);
        }

        [Test]
        public void ShouldShowMenuWhenHighscoreIsFinished()
        {
            _objectUnderTest.Content = null;

            _highscoreVMMock.Raise(p => p.ReturnToMenuRequested += null);

            Assert.AreEqual(_objectUnderTest.Content, _menuVMMock.Object);
        }

        [Test]
        public void ShouldShowMenuWhenPracticeResultIsFinished()
        {
            _objectUnderTest.Content = null;

            _practiceSummaryVMMock.Raise(p => p.ReturnToMenuRequested += null);

            Assert.AreEqual(_objectUnderTest.Content, _menuVMMock.Object);
        }

        [Test]
        public void ShouldInitializeMenuWhenInitializing()
        {
            _objectUnderTest.Initialize();

            _menuVMMock.Verify(p => p.Initialize());
        }

        private List<DictionaryEntry> RaiseStartCompetitionEvent()
        {
            var entries = new List<DictionaryEntry>();
            _menuVMMock.Raise(p => p.StartCompetitionRequested += null, entries);
            return entries;
        }
    }
}
