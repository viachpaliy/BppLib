using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class MacroDataSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new MacroDataSection();
            string expected = "[MACRODATA]";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new MacroDataSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}