using NUnit.Framework;
using BppLib.CIDFile;

namespace BppLib.CIDFile.UnitTests
{
    [TestFixture]
    public class PLineTests
    {
        [Test]
        public void AsCidCodeTest()
        {
            var tech = new Tech();
            tech.Cat = 3;
            tech.Typ = 0;
            tech.Diam = 3.5;
            tech.DepthStart = 8;
            tech.DepthEnd = 8;
            tech.Ang0 = 90;
            tech.Ang1 = 0;
            tech.ToolName = "FABA35";
            var obj = new PLine{TechBlock = tech};
            obj.Geometry.Add(new Line{Xs = -30.000, Ys = 280.250, Zs = 0.0000, Xe = 830.000, Ye = 280.250 , Ze = 0.0000});
            string expected = @"  BEGIN PLINE
	BEGIN TECH
		CAT=3
		TYP=0
		TOOLNAME=FABA35
		DIAM=3.5000
		DEPTH=8.0000,8.0000
		ANG=90.0000,0.0000
	END TECH

	LINE,XS=-30.0000,YS=280.2500,ZS=0.0000,XE=830.0000,YE=280.2500,ZE=0.0000
  END PLINE";
         Assert.AreEqual(expected, obj.AsCidCode());

        }

        [Test]
        public void AsCidBlockTest()
        {
            var tech = new Tech{Cat = 3, Typ = 0, ToolName = "FABA35", Diam = 3.5, DepthStart = 8, DepthEnd = 8, Ang0 = 90, Ang1 = 0};
            var obj = new PLine{TechBlock = tech};
            obj.Geometry.Add(new Line{Xs = -30.000, Ys = 280.250, Zs = 0.0000, Xe = 830.000, Ye = 280.250 , Ze = 0.0000});
            string expected = @"BEGIN BLOCK
  NAME=WRK
  SIDE=0
  BEGIN PLINE
	BEGIN TECH
		CAT=3
		TYP=0
		TOOLNAME=FABA35
		DIAM=3.5000
		DEPTH=8.0000,8.0000
		ANG=90.0000,0.0000
	END TECH

	LINE,XS=-30.0000,YS=280.2500,ZS=0.0000,XE=830.0000,YE=280.2500,ZE=0.0000
  END PLINE
END BLOCK";
            Assert.AreEqual(expected, obj.AsCidBlock());
        }
    }

}