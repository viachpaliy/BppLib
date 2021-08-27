using NUnit.Framework;
using BppLib.CIDFile;

namespace BppLib.CIDFile.UnitTests
{
    [TestFixture]
    public class TechTests
    {
        

        [Test]
        public void AsCidCodeTest_Standart_Constructor()
        {
            var obj = new Tech();
            string expected = @"	BEGIN TECH
		CAT=0
	END TECH";
            Assert.AreEqual(expected, obj.AsCidCode());
        }

        [Test]
        public void AsCidCodeTest_Cat_eq_1()
        {
            var obj = new Tech();
            obj.Cat = 1;
            obj.Typ = 1;
            obj.Diam = 8;
            obj.DepthStart = 13;
            obj.DepthEnd = 13;
            obj.Ang0 = 90;
            obj.Ang1 = 0;
            string expected = @"	BEGIN TECH
		CAT=1
		TYP=1
		DIAM=8.0000
		DEPTH=13.0000,13.0000
		ANG=90.0000,0.0000
	END TECH";
            Assert.AreEqual(expected, obj.AsCidCode());
        }

        [Test]
        public void AsCidCodeTest_Cat_eq_2()
        {
            var obj = new Tech();
            obj.Cat = 2;
            obj.Typ = 0;
            obj.Diam = 20;
            obj.ToolName = "DTN20X45";
            obj.ToolCorTyp = "L,0,L,0";
            obj.Ang0 = 90;
            obj.Ang1 = 0;
            string expected = @"	BEGIN TECH
		CAT=2
		TYP=0
		TOOLNAME=DTN20X45
		DIAM=20.0000
		WORKSPEED=0.0000
		ROTSPEED=0.0000
		DESSPEED=0.0000
		TOOLCORTYP=L,0,L,0
		ANG=90.0000,0.0000
	END TECH";
            Assert.AreEqual(expected, obj.AsCidCode());
        }

        [Test]
        public void AsCidCodeTest_Cat_eq_3()
        {
            var obj = new Tech();
            obj.Cat = 3;
            obj.Typ = 0;
            obj.Diam = 3.5;
            obj.ToolName = "FABA35";
            obj.DepthStart = 10;
            obj.DepthEnd = 10;
            obj.Ang0 = 90;
            obj.Ang1 = 0;
            string expected = @"	BEGIN TECH
		CAT=3
		TYP=0
		TOOLNAME=FABA35
		DIAM=3.5000
		DEPTH=10.0000,10.0000
		WORKSPEED=0.0000
		ROTSPEED=0.0000
		DESSPEED=0.0000
		ANG=90.0000,0.0000
	END TECH";
            Assert.AreEqual(expected, obj.AsCidCode());
        }


    }
}