using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class PCFSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new PCFSection();
            string expected = "[PCF]";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new PCFSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}