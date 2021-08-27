using NUnit.Framework;
using BppLib.CIDFile;

namespace BppLib.CIDFile.UnitTests
{
    [TestFixture]
    public class MainDataTests
    {
        

        [Test]
        public void AsCidCodeTest_Standart_Constructor()
        {
            var obj = new MainData();
            string expected = @"BEGIN MAINDATA
  LX=800.0000
  LY=500.0000
  LZ=30.0000
  OX= 0.00
  OY= 0.00
  OZ= 0.00
	BEGIN TECH
		CAT=0
	END TECH
END MAINDATA";
            Assert.AreEqual(expected, obj.AsCidCode());
        }
    }
}