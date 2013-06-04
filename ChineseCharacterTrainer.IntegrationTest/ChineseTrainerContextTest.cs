﻿using System;
using System.Linq;
using ChineseCharacterTrainer.Model;
using ChineseCharacterTrainer.ServiceApp.Persistence;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data.Entity;

namespace ChineseCharacterTrainer.IntegrationTest
{
    public class ChineseTrainerContextTest
    {
        private const string TestDatabaseName = "ChineseCharacterTrainerTest";

        [TestFixtureSetUp]
        public void Initialize()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ChineseTrainerContext>());

            var objectUnderTest = new ChineseTrainerContext(TestDatabaseName);

            Guard<Dictionary>(objectUnderTest);
            Guard<DictionaryEntry>(objectUnderTest);
            Guard<Translation>(objectUnderTest);
            Guard<Highscore>(objectUnderTest);

            var dictionary1 = CreateDictionary("1");
            objectUnderTest.Add(dictionary1);

            var dictionary2 = CreateDictionary("2");
            objectUnderTest.Add(dictionary2);

            var highscore = CreateHighscore(dictionary1);
            objectUnderTest.Add(highscore);

            objectUnderTest.SaveChanges();
        }

        private static Highscore CreateHighscore(Dictionary dictionary1)
        {
            return new Highscore("Frank", dictionary1.Id, new QuestionResult(1, 0, TimeSpan.FromSeconds(1)));
        }

        private static void Guard<T>(ChineseTrainerContext objectUnderTest) where T : class
        {
            Assert.AreEqual(0, objectUnderTest.GetAll<T>().Count(),
                            string.Format("Guard: Table for type {0} should be empty.", typeof(T)));
        }

        private Dictionary CreateDictionary(string name)
        {
            var entries = new List<DictionaryEntry>
                {
                    new DictionaryEntry("你", "ni3", new List<Translation> {new Translation("you")}),
                    new DictionaryEntry("走", "zou3", new List<Translation> {new Translation("go")})
                };

            var dictionary = new Dictionary(name, entries);
            return dictionary;
        }

        [Test]
        public void ShouldGetDictionariesFromDatabase()
        {
            var objectUnderTest = new ChineseTrainerContext(TestDatabaseName);
            var dictionaries = objectUnderTest.GetAll<Dictionary>().ToList();

            Assert.AreEqual(2, dictionaries.Count);
        }

        [Test]
        public void ShouldGetEntriesFromDatabase()
        {
            var objectUnderTest = new ChineseTrainerContext(TestDatabaseName);
            var entries = objectUnderTest.GetAll<DictionaryEntry>().ToList();

            Assert.AreEqual(4, entries.Count);
        }

        [Test]
        public void ShouldGetTranslationsFromDatabase()
        {
            var objectUnderTest = new ChineseTrainerContext(TestDatabaseName);
            var translations = objectUnderTest.GetAll<Translation>().ToList();

            Assert.AreEqual(4, translations.Count);
        }

        [Test]
        public void ShouldGetHighscoreFromDatabase()
        {
            var objectUnderTest = new ChineseTrainerContext(TestDatabaseName);

            var highscores = objectUnderTest.GetAll<Highscore>().ToList();

            Assert.AreEqual(1, highscores.Count);
        }

    }
}
