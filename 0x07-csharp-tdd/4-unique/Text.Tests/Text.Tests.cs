using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test_unique_true()
        {
            string myString = "aaaasa";

            Assert.AreEqual(Text.Str.UniqueChar(myString), 4);
        }

        [Test]
        public void Test_unique_true_last()
        {
            string myString = "aaaaaas";

            Assert.AreEqual(Text.Str.UniqueChar(myString), myString.Length - 1);
        }

        [Test]
        public void Test_unique_true_start()
        {
            string myString = "saaaaaa";

            Assert.AreEqual(Text.Str.UniqueChar(myString), 0);
        }

        [Test]
        public void Test_unique_false()
        {
            string myString = "heeeeh";

            Assert.AreEqual(Text.Str.UniqueChar(myString), -1);
        }

        [Test]
        public void Test_unique_sameChar()
        {
            string myString = "eeeeeee";

            Assert.AreEqual(Text.Str.UniqueChar(myString), -1);
        }

        [Test]
        public void Test_unique_empty()
        {
            string myString = "";

            Assert.AreEqual(Text.Str.UniqueChar(myString), -1);
        }
    }
}