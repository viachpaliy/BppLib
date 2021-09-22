using NUnit.Framework;
using BppLib.CIDFile;

namespace BppLib.CIDFile.UnitTests
{
    [TestFixture]
    public class PointTests
    {
        

        [Test]
        public void AsCidCodeTest()
        {
            var obj = new Point{X=9.000,Y=50.000,Z=0.000};
            string expected = @"	POINT,X=9.0000,Y=50.0000,Z=0.0000";
            Assert.AreEqual(expected, obj.AsCidCode());
        }
    }
}