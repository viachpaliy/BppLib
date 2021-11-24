using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class WFGPSTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new WFGPS();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
           string giz = "P1007";
            var obj = new WFGPS{Giz = giz};
            Assert.AreEqual(giz, obj.Giz);
         }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new WFGPS();
            int i = 158181732 ;
            obj.Id = i ;
            string expected = "@ WFGPS, \"\", \"\", 158181732, \"\", 0 : 6, \"\", \"\", 0, 0, 0, \"WFGPS\"";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

    
        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new WFGPS();
            string expected =@"BEGIN MACRO
	NAME=WFGPS
	PARAM,NAME=ID,VALUE=6
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=GIZ,VALUE=""""
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=PS,VALUE=NO
	PARAM,NAME=LAY,VALUE=""WFGPS""
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}