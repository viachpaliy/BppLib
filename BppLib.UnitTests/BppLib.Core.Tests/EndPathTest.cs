using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class EndPathTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var ep = new EndPath();
            int i = 123456789 ;
            ep.Id = i ; 
            Assert.AreEqual(i, ep.Id);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var ep = new EndPath();
            int i = 158601252 ;
            ep.Id = i ;
            string expected = "@ ENDPATH, \"\", \"\", 158601252, \"\", 0 :" ;
            Assert.AreEqual(expected, ep.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var ep = new EndPath();
            int i = 158182436 ;
            ep.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=ENDPATH
	PARAM,NAME=ID,VALUE=158182436
END MACRO";
            Assert.AreEqual(expected, ep.AsCixCode());
        }
    }
}