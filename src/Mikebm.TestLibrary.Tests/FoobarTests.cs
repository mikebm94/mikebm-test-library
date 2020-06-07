using NUnit.Framework;

namespace Mikebm.TestLibrary.Tests
{
    [TestFixture]
    public class FoobarTests
    {
        [Test]
        public void GetGreeting_ReturnsHelloWorld()
        {
            var foobar = new Foobar();

            string greeting = foobar.GetGreeting();

            Assert.AreEqual("Hello World!", greeting);
        }

        [Test]
        public void GetSeven_Returns7()
        {
            var foobar = new Foobar();

            int result = foobar.GetSeven();

            Assert.AreEqual(7, result);
        }
    }
}