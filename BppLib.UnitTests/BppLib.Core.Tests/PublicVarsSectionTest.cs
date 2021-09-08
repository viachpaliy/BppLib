using NUnit.Framework;
using BppLib.Core;
using System.Collections.Generic;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class PublicVarsSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest_withoutVariables()
        {
            var obj = new PublicVarsSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

         [Test]
        public void AsBppCodeMethodTest_withVariables()
        {
            var obj = new PublicVarsSection();
            var H = new BiesseVariable{Name = "H", Value = "8", Description = "Angle", Typ = BiesseVariablesType.Angle};
            var A = new BiesseVariable{Name = "A", Value = "10", Description = "Generic", Typ = BiesseVariablesType.General};
            var B = new BiesseVariable{Name = "B", Value = "1,2", Description = "String", Typ = BiesseVariablesType.String};
            var D = new BiesseVariable{Name = "D", Value = "4", Description = "Procent", Typ = BiesseVariablesType.Percentage};
            var F = new BiesseVariable{Name = "F", Value = "6", Description = "Velocity", Typ = BiesseVariablesType.Velocity};
            var G = new BiesseVariable{Name = "G", Value = "7.3", Description = "Real", Typ = BiesseVariablesType.Real};
            var J = new BiesseVariable{Name = "J", Value = "9", Description = "Integer", Typ = BiesseVariablesType.Integer};
            obj.PublicVariables = new List<BiesseVariable>(){H, A, B, D, F, G, J};
            string expected = @"
GLB=H|8|Angle|6|
GLB=A|10|Generic|0|
GLB=B|""1,2""|String|3|
GLB=D|4|Procent|8|
GLB=F|6|Velocity|5|
GLB=G|7.3|Real|2|
GLB=J|9|Integer|1|";
            Assert.AreEqual(expected, obj.AsBppCode());
        }
    

        [Test]
        public void AsCixCodeMethodTest_withoutVariables()
        {
            var obj = new PublicVarsSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsCixCode());
        }

        [Test]
        public void AsCixCodeMethodTest_withVariables()
        {
            var obj = new PublicVarsSection();
            var H = new BiesseVariable{Name = "H", Value = "8", Description = "Angle", Typ = BiesseVariablesType.Angle};
            var A = new BiesseVariable{Name = "A", Value = "10", Description = "Generic", Typ = BiesseVariablesType.General};
            var B = new BiesseVariable{Name = "B", Value = "1,2", Description = "String", Typ = BiesseVariablesType.String};
            var D = new BiesseVariable{Name = "D", Value = "4", Description = "Procent", Typ = BiesseVariablesType.Percentage};
            var F = new BiesseVariable{Name = "F", Value = "6", Description = "Velocity", Typ = BiesseVariablesType.Velocity};
            var G = new BiesseVariable{Name = "G", Value = "7.3", Description = "Real", Typ = BiesseVariablesType.Real};
            var J = new BiesseVariable{Name = "J", Value = "9", Description = "Integer", Typ = BiesseVariablesType.Integer};
            obj.PublicVariables = new List<BiesseVariable>(){H, A, B, D, F, G, J};
            string expected = @"
BEGIN PUBLICVARS
	PARAM, NAME=H, VALUE=8, DESCRIPTION=""Angle"", TYPE=6
	PARAM, NAME=A, VALUE=10, DESCRIPTION=""Generic"", TYPE=0
	PARAM, NAME=B, VALUE=""1,2"", DESCRIPTION=""String"", TYPE=3
	PARAM, NAME=D, VALUE=4, DESCRIPTION=""Procent"", TYPE=8
	PARAM, NAME=F, VALUE=6, DESCRIPTION=""Velocity"", TYPE=5
	PARAM, NAME=G, VALUE=7.3, DESCRIPTION=""Real"", TYPE=2
	PARAM, NAME=J, VALUE=9, DESCRIPTION=""Integer"", TYPE=1
END PUBLICVARS";
            Assert.AreEqual(expected, obj.AsCixCode());
        }


    }
}