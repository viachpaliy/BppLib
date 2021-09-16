using NUnit.Framework;
using BppLib.CIDFile;

namespace BppLib.CIDFile.UnitTests
{
    [TestFixture]
    public class ArcTests
    {
        [Test]
        public void AsCidCodeTest()
        {
            var obj = new Arc{Xs=400.0000,Ys=300.0000,Zs=10.0000,Xe=500.0000,Ye=200.0000,Ze=10.0000,Xc=400.0000,Yc=200.0000,Zc=0.0000,R=100.0000,V=false};
            string expected = @"	ARC ,XS=400.0000,YS=300.0000,ZS=10.0000,XE=500.0000,YE=200.0000,ZE=10.0000,XC=400.0000,YC=200.0000,ZC=0.0000,R=100.0000,V=A";
            Assert.AreEqual(expected, obj.AsCidCode());
        }

    }
}