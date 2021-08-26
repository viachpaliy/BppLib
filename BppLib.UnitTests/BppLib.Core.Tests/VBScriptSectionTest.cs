using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class VBScriptSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new VBScriptSection();
            string expected = "[VBSCRIPT]";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new VBScriptSection();
            string expected = @"BEGIN VB
	VBLINE=""""
END VB";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}