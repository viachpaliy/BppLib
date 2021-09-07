using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class OffGeoTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new OffGeo();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            var obj = new OffGeo{Ofs = xi};
            Assert.AreEqual(xi, obj.Ofs);
         }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new OffGeo();
            int i = 213549532 ;
            obj.IntId = i ;
            obj.Id = "P1014";
            string expected = "@ OFFGEO, \"\", \"\", 213549532, \"\", 0 : \"P1014\", \"\", \"\", \"OFFGEO\", 0, 0, 0, 0, 0, 1" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new OffGeo();
            obj.Id = "P1014";
            string expected =@"BEGIN MACRO
	NAME=OFFGEO
	PARAM,NAME=ID,VALUE=""P1014""
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=SIL,VALUE=""""
	PARAM,NAME=LAY,VALUE=""OFFGEO""
	PARAM,NAME=OFS,VALUE=0
	PARAM,NAME=SHC,VALUE=NO
	PARAM,NAME=OSL,VALUE=oslTan
	PARAM,NAME=LTP,VALUE=NO
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=CRT,VALUE=1
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}