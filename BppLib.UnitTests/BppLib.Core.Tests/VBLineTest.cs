using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class VBLineTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new VBLine();
            string code = @"Dim Xi,Yi
If D=5 Then";
            obj.Code = code;
            string expected = @"Dim Xi,Yi
If D=5 Then";
            
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new VBLine();
            string code = @"Dim Xi,Yi
If D=5 Then";
            obj.Code = code;
            string expected = @"BEGIN VB
	VBLINE=""Dim Xi,Yi""
	VBLINE=""If D=5 Then""
END VB";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}