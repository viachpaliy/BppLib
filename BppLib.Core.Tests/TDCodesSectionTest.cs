using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class TDCodesSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new TDCodesSection();
            string expected = "[TDCODES]";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new TDCodesSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}