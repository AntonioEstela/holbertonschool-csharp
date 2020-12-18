using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_camelCase_true()
        {
            string phrase = "helloHowAreYouDoing?";

            Assert.AreEqual(Text.Str.CamelCase(phrase), 5);
        }

        [Test]
        public void Test_camelCase_false()
        {
            string phrase = "";

            Assert.AreEqual(Text.Str.CamelCase(phrase), 0);
        }

        [Test]
        public void Test_camelCase_null()
        {
            string phrase = null;

            Assert.AreEqual(Text.Str.CamelCase(phrase), 0);
        }
    }
}