using NameSorter.ConsoleUI.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Swinkaran.NameSorter.Tests
{
    [TestFixture]
    public class NameSortingTests
    {
        IList<Person> PersonNames;
        Features.Sorting.IPersonSorter<Person> Sorter;

        public NameSortingTests() { }

        [SetUp]
        public void Setup()
        {
            PersonNames = new List<Person> {
                new Person(new string[] {"Janet" },"Parsons"),
                    new Person(new string[] { "Vaughn" },"Lewis"),
                        new Person(new string[]{"Julius" },"Archer"),
                        new Person(new string[]{"Leo","Beta" },"Gardner"),
                        new Person(new string[]{"Shelby","Nathan" },"Yoder"),
                        new Person(new string[]{"Leo","Alpha" },"Gardner"),
                        new Person(new string[]{"Marin" },"Alvarez"),
                        new Person(new string[]{"London" },"Lindsey"),
                        new Person(new string[]{"Beau","Tristan" },"Bentley"),
                        new Person(new string[]{"Hunter","Uriah","Mathew" },"Clarke"),
                        new Person(new string[]{"Mikayla" },"Lopez"),
                        new Person(new string[]{"Frankie","Conner" },"Ritter")
            };
            Sorter = new Features.Sorting.PersonSorter(PersonNames);
        }

        [Test, Order(1)]
        public void FirstElementShouldbeInFirst()
        {
            IList<Person> sortedList = Sorter.SortByName();
            Assert.That(sortedList[0].LastName, Is.EqualTo("Alvarez"));
        }

        [Test, Order(2)]
        public void LastElementShouldbeInLast()
        {
            IList<Person> sortedList = Sorter.SortByName();
            Assert.That(sortedList[sortedList.Count - 1].LastName, Is.EqualTo("Yoder"));
        }
        
        #region Mathcing Lastnames
        [Test, Order(3)]
        public void ShouldOrderByGivenNameOnLAstNameMatch()
        {
            IList<Person> sortedList = Sorter.SortByName();
            var alphaIndex = sortedList.IndexOf(sortedList.Where(p => p.GivenName.Contains("Alpha")).First());
            var betaIndex = sortedList.IndexOf(sortedList.Where(p => p.GivenName.Contains("Beta")).First());

            Assert.That(alphaIndex < betaIndex);
        }
        #endregion
    }
}
