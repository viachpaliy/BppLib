using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class LineAnYeTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new LineAnYe();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new LineAnYe{A = yi, Ye = xi};
            Assert.AreEqual(xi, obj.Ye);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new LineAnYe();
            int i = 158597220 ;
            obj.Id = i ;
            string expected = "@ LINE_ANYE, \"\", \"\", 158597220, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest_withRealData()
        {
            var obj = new LineAnYe{Id = 97455540, A = 45.1365, Ye = 100.3, Zs = 2.5, Ze = 3.1};
            string expected = "@ LINE_ANYE, \"\", \"\", 97455540, \"\", 0 : 45.1365, 100.3, 2.5, 3.1, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new LineAnYe();
            int i = 158597220 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=LINE_ANYE
	PARAM,NAME=ID,VALUE=158597220
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=YE,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}