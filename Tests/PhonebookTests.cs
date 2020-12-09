using FTFa;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    class PhonebookTests
    {
        private Phonebook phonebook;

        [SetUp]
        public void Setup()
        {
            phonebook = new Phonebook();
        }

        [TestCase]
        public void EmptyGetEntries()
        {
            CollectionAssert.AreEqual(phonebook.GetEntries(), new Dictionary<string, string>());
        }

        [TestCase("test", "12345678")]
        public void PopulatedGetEntries(string name, string number)
        {
            Assert.IsTrue(phonebook.AddEntry(number, name));
            CollectionAssert.AreNotEqual(phonebook.GetEntries(), new Dictionary<string, string>());
            KeyValuePair<string, string> entry = new KeyValuePair<string, string>(number, name);
            CollectionAssert.Contains(phonebook.GetEntries(), entry);
        }

        [TestCase("test", "12345678")]
        public void SuccessAddEntry(string name, string number)
        {
            Assert.IsTrue(phonebook.AddEntry(number, name));
        }


        [TestCase("test", "12345678")]
        public void FailureAddEntry(string name, string number)
        {
            Assert.IsTrue(phonebook.AddEntry(number, name));
            Assert.IsFalse(phonebook.AddEntry(number, name));
        }
    }
}
