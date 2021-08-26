using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class StartPointTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var ep = new StartPoint();
            int i = 123456789 ;
            ep.Id = i ; 
            Assert.AreEqual(i, ep.Id);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var ep = new StartPoint();
            int i = 159159172 ;
            ep.Id = i ;
            string expected = "@ START_POINT, \"\", \"\", 159159172, \"\", 0 : 0, 0, 0" ;
            Assert.AreEqual(expected, ep.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var ep = new StartPoint();
            int i = 159159172 ;
            ep.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=START_POINT
	PARAM,NAME=ID,VALUE=159159172
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
END MACRO";
            Assert.AreEqual(expected, ep.AsCixCode());
        }
    }
}