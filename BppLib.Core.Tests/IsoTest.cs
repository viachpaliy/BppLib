using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class IsoTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Iso();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            string text = "Hello World";
            var obj = new Iso{IsoText = text};
            Assert.AreEqual(text, obj.IsoText);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Iso();
            int i = 158188452 ;
            obj.Id = i ;
            string expected = "@ ISO, \"\", \"\", 158188452, \"\", 0 : \"\"" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Iso();
            int i = 158188452 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=ISO
	PARAM,NAME=ISO,VALUE=""""
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}