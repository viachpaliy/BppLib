using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class WFGLTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new WFGL();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
           string giz = "P1007";
            var obj = new WFGL{Giz = giz};
            Assert.AreEqual(giz, obj.Giz);
         }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new WFGL();
            int i = 158188836 ;
            obj.Id = i ;
            string expected = "@ WFGL, \"\", \"\", 158188836, \"\", 0 : 6, \"\", 0, 0, \"WFGL\"";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

    
        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new WFGL();
            string expected =@"BEGIN MACRO
	NAME=WFGL
	PARAM,NAME=ID,VALUE=6
	PARAM,NAME=GIZ,VALUE=""""
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=LAY,VALUE=""WFGL""
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}