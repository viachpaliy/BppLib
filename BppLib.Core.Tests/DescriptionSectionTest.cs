using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class DescriptionSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new DescriptionSection();
            string text = "Simple boring.\r\nSimple programme.";
            obj.DescText = text;
            string expected = @"[DESCRIPTION]
|Simple boring.
|Simple programme.";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new DescriptionSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}