using System;
using System.Collections.Generic;
using NUnit;
using NUnit.Framework;

namespace Swinkaran.NameSorter.Tests
{
    [TestFixture]
    public class NameSortingTests
    {

        
        public NameSortingTests() { }

        [SetUp]
        public void Setup()
        {
        }

        [Test, Order(1)]
        public void FirstElementShouldbeInFirst()
        {
            
        }

        [Test, Order(2)]
        public void LastElementShouldbeInLast()
        {
            
        }

        [Test, Order(3)]
        public void ShouldBeOrderedInAsc()
        {
        }

    }
}
