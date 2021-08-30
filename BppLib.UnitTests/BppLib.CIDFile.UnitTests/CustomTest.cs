using NUnit.Framework;
using BppLib.CIDFile;

namespace BppLib.CIDFile.UnitTests
{
    [TestFixture]
    public class CustomTests
    {
        [Test]
        public void AsCidCodeTest()
        {
            var tech = new Tech();
            tech.Cat = 1;
            tech.Typ = 1;
            tech.Diam = 8;
            tech.DepthStart = 13;
            tech.DepthEnd = 13;
            tech.Ang0 = 90;
            tech.Ang1 = 0;
            var obj = new Custom{TechBlock = tech, RefPoint = 2, X = 9.2, Y = 82};
            string expected = @"  BEGIN CUSTOM
	BEGIN TECH
		CAT=1
		TYP=1
		DIAM=8.0000
		DEPTH=13.0000,13.0000
		ANG=90.0000,0.0000
	END TECH
	REFPOINT=2 
	POINT,X=9.2000,Y=82.0000,Z=0.0000
  END CUSTOM";
            Assert.AreEqual(expected, obj.AsCidCode());

        }

        [Test]
        public void AsCidBlockTest()
        {
            var tech = new Tech{Cat = 1, Typ =1, ToolName = "DN10X30", Diam = 10, DepthStart = 13, DepthEnd = 13, Ang0 = 90, Ang1 = 0};
            var obj = new Custom{TechBlock = tech, RefPoint = 2, X = 490, Y = 70};
            string expected = @"BEGIN BLOCK
  NAME=WRK
  BEGIN CUSTOM
	BEGIN TECH
		CAT=1
		TYP=1
		TOOLNAME=DN10X30
		DIAM=10.0000
		DEPTH=13.0000,13.0000
		ANG=90.0000,0.0000
	END TECH
	REFPOINT=2 
	POINT,X=490.0000,Y=70.0000,Z=0.0000
  END CUSTOM
END BLOCK";
            Assert.AreEqual(expected, obj.AsCidBlock());
        }
    }

}