using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>Provides testscases for MaxInteger method.</summary>
    public class MaxIntegerTests
    {
        [Test]
        public void Test_when_all_positive()
        {
            List<int> intList = new List<int>() {1, 2, 3, 9, 5, 6, 23};

            Assert.AreEqual(MyMath.Operations.Max(intList), 23);
        }

        [Test]
        public void Test_when_all_negative()
        {
            List<int> intList = new List<int>() {-1, -2, -3, -9, -5, -6, -23};

            Assert.AreEqual(MyMath.Operations.Max(intList), -1);
        }

        
        [Test]
        public void Test_when_all_equals()
        {
            List<int> intList = new List<int>() {3, 3, 3, 3, 3};

            Assert.AreEqual(MyMath.Operations.Max(intList), 3);
        }

        [Test]
        public void Test_when_list_null()
        {
            Assert.AreEqual(MyMath.Operations.Max(null), 0);
        }

        [Test]
        public void Test_when_list_empty()
        {
            Assert.AreEqual(MyMath.Operations.Max(new List<int>()), 0);
        }
    }
}