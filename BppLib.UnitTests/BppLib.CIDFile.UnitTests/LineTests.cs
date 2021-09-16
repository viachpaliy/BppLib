using NUnit.Framework;
using BppLib.CIDFile;

namespace BppLib.CIDFile.UnitTests
{
    [TestFixture]
    public class LineTests
    {
        [Test]
        public void AsCidCodeTest()
        {
            var obj = new Line{Xs=100.0000,Ys=110.0000,Zs=10.0000,Xe=100.0000,Ye=200.0000,Ze=10.0000 };
            string expected = @"	LINE,XS=100.0000,YS=110.0000,ZS=10.0000,XE=100.0000,YE=200.0000,ZE=10.0000";
            Assert.AreEqual(expected, obj.AsCidCode());
        }

    }
}