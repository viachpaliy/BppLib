using NUnit.Framework;
using BppLib.Core;
using System.Collections.Generic;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class PrivateVarsSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest_withoutVariables()
        {
            var obj = new PrivateVarsSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

         [Test]
        public void AsBppCodeMethodTest_withVariables()
        {
            var obj = new PrivateVarsSection();
            var C = new BiesseVariable{Name = "C", Value = "3", Description = "Time", Typ = BiesseVariablesType.Time};
            var E = new BiesseVariable{Name = "E", Value = "5", Description = "Distance", Typ = BiesseVariablesType.Distance};
            obj.PrivateVariables = new List<BiesseVariable>(){C, E};
            string expected = @"
LOC=C|3|Time|7|
LOC=E|5|Distance|4|";
            Assert.AreEqual(expected, obj.AsBppCode());
        }
    

        [Test]
        public void AsCixCodeMethodTest_withoutVariables()
        {
            var obj = new PrivateVarsSection();
            string expected = "";
            Assert.AreEqual(expected, obj.AsCixCode());
        }

        [Test]
        public void AsCixCodeMethodTest_withVariables()
        {
            var obj = new PrivateVarsSection();
            var C = new BiesseVariable{Name = "C", Value = "3", Description = "Time", Typ = BiesseVariablesType.Time};
            var E = new BiesseVariable{Name = "E", Value = "5", Description = "Distance", Typ = BiesseVariablesType.Distance};
            obj.PrivateVariables = new List<BiesseVariable>(){C, E};
            string expected = @"
BEGIN PRIVATEVARS
	PARAM, NAME=C, VALUE=3, DESCRIPTION=""Time"", TYPE=7
	PARAM, NAME=E, VALUE=5, DESCRIPTION=""Distance"", TYPE=4
END PRIVATEVARS";
            Assert.AreEqual(expected, obj.AsCixCode());
        }


    }
}