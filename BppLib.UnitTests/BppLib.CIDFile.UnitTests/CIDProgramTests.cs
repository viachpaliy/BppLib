using NUnit.Framework;
using BppLib.CIDFile;

namespace BppLib.CIDFile.UnitTests
{
    [TestFixture]
    public class CIDProgramTests
    {
         [Test]
        public void AsCidCodeTest_One_Bore()
        {
            var tech = new Tech();
            tech.Cat = 1;
            tech.Typ = 2;
            tech.Diam = 7;
            tech.DepthStart = 23;
            tech.DepthEnd = 23;
            tech.Ang0 = 90;
            tech.Ang1 = 0;
            var custom = new Custom{TechBlock = tech, RefPoint = 2, X = 9, Y = 50};
            var obj = new CIDProgram{Lx = 600, Ly = 350, Lz = 18, FileName = "OneBore"};
            obj.Operations.Add(custom);
            string expected = @"BEGIN ID CID3
'""OneBore""
  REL= 3.0
  AXIS=x+,y-,z-
END ID
BEGIN MAINDATA
  LX=600.0000
  LY=350.0000
  LZ=18.0000
  OX= 0.00
  OY= 0.00
  OZ= 0.00
	BEGIN TECH
		CAT=0
	END TECH
END MAINDATA
BEGIN BLOCK
  NAME=WRK
  BEGIN CUSTOM
	BEGIN TECH
		CAT=1
		TYP=2
		DIAM=7.0000
		DEPTH=23.0000,23.0000
		ANG=90.0000,0.0000
	END TECH
	REFPOINT=2 
	POINT,X=9.0000,Y=50.0000,Z=0.0000
  END CUSTOM
END BLOCK";
            Assert.AreEqual(expected, obj.AsCidCode());
        }
    }

}