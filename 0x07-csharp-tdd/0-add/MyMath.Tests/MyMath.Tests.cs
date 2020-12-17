using NUnit.Framework;

namespace Tests
{
    /// <summary>Provides Tests for Operation class</summary>
    [TestFixture]
    public class OperationsTests
    {
    
        [Test]

        /// <summary>Tests when the user adds 2 positive integers</summary>
        public void Test_adding_two_positive_integers()
        {
            int a = 4;
            int b = 5;
            Assert.AreEqual(MyMath.Operations.Add(a, b), 9);
        }

        [Test]

        /// <summary>Tests when the user adds 2 negative integers</summary>
        public void Test_adding_two_negative_integers()
        {
            Assert.AreEqual(MyMath.Operations.Add(-5, -15), -20);
        }

        [TestCase(5, 9)]
        [TestCase(20, -50)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]

        [Test]
        
        /// <summary>Tests when the user adds 2 integers</summary>
        public void Test_adding_two_integers(int a, int b)
        {
            Assert.AreEqual(MyMath.Operations.Add(a, b), a + b);
        }
    }
}