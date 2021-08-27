using NUnit.Framework;
using BppLib.CIDFile;

namespace BppLib.CIDFile.UnitTests
{
    [TestFixture]
    public class FileIdTests
    {
        

        [Test]
        public void AsCidCodeTest()
        {
            var obj = new FileId();
            obj.FileName = "SimpleBoring";
            string expected = @"BEGIN ID CID3
'""SimpleBoring""
  REL= 3.0
  AXIS=x+,y-,z-
END ID";
            Assert.AreEqual(expected, obj.AsCidCode());
        }
    }
}