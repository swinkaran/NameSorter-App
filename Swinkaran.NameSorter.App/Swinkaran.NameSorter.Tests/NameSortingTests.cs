using System;
using System.Collections.Generic;
using NUnit;
using NUnit.Framework;
using NameSorter.ConsoleUI.Model;

namespace Swinkaran.NameSorter.Tests
{
    [TestFixture]
    public class NameSortingTests
    {
        IList<Person> PersonList;

        public NameSortingTests() { }

        [SetUp]
        public void Setup()
        {
            PersonList = new List<Person> {
                //new Person("Janet","Parsons"),
                //    new Person("Vaughn","Lewis"),
                //        new Person("Julius","Archer"),
                //        new Person("Shelby Nathan","Yoder"),
                //        new Person("Leo Alpha","Gardner"),
                //        new Person("Marin","Alvarez"),
                //        new Person("London","Lindsey"),
                //        new Person("Beau Tristan","Bentley"),
                //        new Person("Leo Beta","Gardner"),
                //        new Person("Hunter Uriah Mathew","Clarke"),
                //        new Person("Mikayla","Lopez"),
                //        new Person("Frankie Conner","Ritter")
            };
        }

        [Test, Order(1)]
        public void FirstElementShouldbeInFirst()
        {
            var list = PersonList;
          
        }

        [Test, Order(2)]
        public void LastElementShouldbeInLast()
        {

        }

        [Test, Order(3)]
        public void ShouldBeOrderedInAsc()
        {
        }

        #region Mathcing Lastnames
        [Test, Order(4)]
        public void ShouldOrderByGivenName()
        {
        }
        #endregion
    }
}
