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
    }
}