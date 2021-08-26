using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class SubProgsSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new SubProgsSection();
            string expected = "[SUBPROGS]";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new SubProgsSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}