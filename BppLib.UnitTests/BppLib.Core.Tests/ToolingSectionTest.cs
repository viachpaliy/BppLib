using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ToolingSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new ToolingSection();
            string expected = "[TOOLING]";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new ToolingSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}