using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class HeaderSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new HeaderSection();
            string expected = @"[HEADER]
TYPE=BPP
VER=150";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new HeaderSection();
            string expected = @"BEGIN ID CID3
	REL= 5.0
END ID";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}