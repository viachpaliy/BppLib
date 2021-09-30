using NUnit.Framework;
using Jurassic;
using Fusion360PostProcessor;
using System;

namespace Fusion360PostProcessor.UnitTests
{
    [TestFixture]
    public class Fu360PostProcessorTests
    {
        [Test]
        public void TestDescription()
        {
            string testCode = "description = \"SCM-Prisma 110\";";
            string expected ="SCM-Prisma 110";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.Description);
        }

        [Test]
        public void TestVendor()
        {
            string testCode = "vendor = \"SCM\";";
            string expected ="SCM";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.Vendor);
        }

        [Test]
        public void TestVendorUrl()
        {
            string testCode = "vendorUrl = \"http://www.scmgroup.com\";";
            string expected ="http://www.scmgroup.com";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.VendorUrl);
        }

        [Test]
        public void TestLegal()
        {
            string testCode = "legal = \"Copyright (C) 2012-2021 by Autodesk, Inc.\";";
            string expected ="Copyright (C) 2012-2021 by Autodesk, Inc.";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.Legal);
        }

        [Test]
        public void TestLongDescription()
        {
            string testCode = "longDescription = \"Generic post for SCM-Prisma 110.\";";
            string expected ="Generic post for SCM-Prisma 110.";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.LongDescription);
        }

        [Test]
        public void TestExtension()
        {
            string testCode = "extension = \"xxl\";";
            string expected ="xxl";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.Extension);
        }

        [Test]
        public void TestCertificationLevel()
        {
            string testCode = "certificationLevel = 2;";
            int expected = 2;
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.CertificationLevel);
        }

        [Test]
        public void TestMinimumRevision()
        {
            string testCode = "minimumRevision = 45702;";
            int expected = 45702;
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.MinimumRevision);
        }

         [Test]
        public void TestCodePage()
        {
            string testCode = "setCodePage(\"utf-8\");";
            string expected ="utf-8";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.CodePage);
        }

         [Test]
        public void TestCapabilities()
        {
            string testCode = "capabilities = CAPABILITY_MILLING | CAPABILITY_TURNING;";
            int expected = 3;
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.Capabilities);
        }

        [Test]
        public void TestTolerance()
        {
            string testCode = "tolerance = spatial(0.0001, IN);";
            double expected = 0.0001 * 25.4;
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, obj.Tolerance);
        }

        [Test]
        public void TestGetProperty()
        {
            string testCode = @"properties = {
    sequenceNumberStart: {
    title: ""Start sequence number"",
    description: ""The number at which to start the sequence numbers."",
    group: 1,
    type: ""integer"",
    value: 101,
    scope: ""post""
  }
        };";

            int expected = 101;        
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<int>("getProperty(\"sequenceNumberStart\")"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-67</summary>
        /// <code>
        /// var xFormat = createFormat({decimals:3, trim:false, forceSign:true});
        /// xFormat.format(4.5); // returns "+4.500"
        /// </code>
        [Test]
        public void TestCreateFormat_ExampleN1()
        {
            string testCode = @"var xFormat = createFormat({decimals:3, trim:false, forceSign:true});";
            string expected = "+4.500";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<string>("xFormat.format(4.5)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-68</summary>
        /// <code>
        /// var yFormat = createFormat({decimals:3, forceSign:true});
        /// yFormat.format(4.5); // returns "+4.5"
        /// </code>
        [Test]
        public void TestCreateFormat_ExampleN2()
        {
            string testCode = @"var yFormat = createFormat({decimals:3, forceSign:true});";
            string expected = "+4.5";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<string>("yFormat.format(4.5)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-68</summary>
        /// <code>
        /// var toolFormat = createFormat({prefix:"T", decimals:0, zeropad:true, width:2});
        /// toolFormat.format(7); // returns "T07"
        /// </code>
        [Test]
        public void TestCreateFormat_ExampleN3()
        {
            string testCode = @"var toolFormat = createFormat({prefix:""T"", decimals:0, zeropad:true, width:2});";
            string expected = "T07";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<string>("toolFormat.format(7)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-68</summary>
        /// <code>
        /// var aFormat = createFormat({decimals:3, forceSign:true, forceDecimal:true, scale:DEG});
        /// aFormat.format(Math.PI); // returns "+180."
        /// </code>
        [Test]
        public void TestCreateFormat_ExampleN4()
        {
            string testCode = @"var aFormat = createFormat({decimals:3, forceSign:true, forceDecimal:true, scale:DEG});";
            string expected = "+180.";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<string>("aFormat.format(Math.PI)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-68</summary>
        /// <code>
        /// var zFormat = createFormat({decimals:4, scale:10000, forceDecimal:false});
        /// zFormat.format(1.23); // returns 12300 (leading zero suppression)
        /// </code>
        [Test]
        public void TestCreateFormat_ExampleN5()
        {
            string testCode = @"var zFormat = createFormat({decimals:4, scale:10000, forceDecimal:false});";
            string expected = "12300";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<string>("zFormat.format(1.23)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-67</summary>
        /// <code>
        /// var xFormat = createFormat({decimals:3, trim:false, forceSign:true});
        /// xFormat.areDifferent(9.123, 9.1234); // returns false, both numbers are 9.123
        /// </code>
        [Test]
        public void TestCreateFormat_areDifferent_Test()
        {
            string testCode = @"var xFormat = createFormat({decimals:3, trim:false, forceSign:true});";
            bool expected = false;
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<bool>("xFormat.areDifferent(9.123, 9.1234)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-67</summary>
        /// <code>
        /// var xFormat = createFormat({decimals:3, trim:false, forceSign:true});
        /// xFormat.getMinimumValue(); // returns 0.001
        /// </code>
        [Test]
        public void TestCreateFormat_getMinimumValue_Test()
        {
            string testCode = @"var xFormat = createFormat({decimals:3, trim:false, forceSign:true});";
            double expected = 0.001;
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<double>("xFormat.getMinimumValue()"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-67</summary>
        [Test]
        public void TestCreateFormat_getError_Test()
        {
            string testCode = @"var xFormat = createFormat({decimals:3, trim:false, forceSign:true});";
            double expected = -0.0005;
            int precision = 9;
            double tolerance = 1.0 / Math.Pow(10, precision);
            var obj = new Fu360PostProcessor(testCode, false);
            double actual = Fu360PostProcessor.engine.Evaluate<double>("xFormat.getError(4.5005)");
            Assert.That(actual, Is.EqualTo(expected).Within(tolerance));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-68</summary>
        /// <code>
        /// var yFormat = createFormat({decimals:3, forceSign:true});
        /// yFormat.getResultingValue(3.1234); // returns 3.123
        /// </code>
        [Test]
        public void TestCreateFormat_getResultingValue_Test()
        {
            string testCode = @"var yFormat = createFormat({decimals:3, forceSign:true});";
            double expected = 3.123;
            int precision = 6;
            double tolerance = 1.0 / Math.Pow(10, precision);
            var obj = new Fu360PostProcessor(testCode, false);
            double actual = Fu360PostProcessor.engine.Evaluate<double>("yFormat.getResultingValue(3.1234)");
            Assert.That(actual, Is.EqualTo(expected).Within(tolerance));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-67</summary>
        /// <code>
        /// var xFormat = createFormat({decimals:3, trim:false, forceSign:true});
        /// xFormat.isSignificant(.0005); // returns true (rounded to .001)
        /// </code>
        [Test]
        public void TestCreateFormat_isSignificant_return_true()
        {
            string testCode = @"var xFormat = createFormat({decimals:3, trim:false, forceSign:true});";
            bool expected = true;
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<bool>("xFormat.isSignificant(.0005)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-67</summary>
        /// <code>
        /// var xFormat = createFormat({decimals:3, trim:false, forceSign:true});
        /// xFormat.isSignificant(.00049); // returns false
        /// </code>
        [Test]
        public void TestCreateFormat_isSignificant_return_false()
        {
            string testCode = @"var xFormat = createFormat({decimals:3, trim:false, forceSign:true});";
            bool expected = false;
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<bool>("xFormat.isSignificant(.00049)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-70</summary>
        /// <code>
        /// var xyzFormat = createFormat({decimals:3, forceDecimal:true});
        /// var xOutput = createVariable({prefix:"X"}, xyzFormat);
        /// xOutput.format(4.5); // returns "X4.5"
        /// </code>
        [Test]
        public void TestCreateFormat_createVariable_N1()
        {
            string testCode = @"var xyzFormat = createFormat({decimals:3, forceDecimal:true});
var xOutput = createVariable({prefix:""X""}, xyzFormat);";
            string expected = "X4.5";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<string>("xOutput.format(4.5)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-70</summary>
        /// <code>
        /// var xyzFormat = createFormat({decimals:3, forceDecimal:true});
        /// var xOutput = createVariable({prefix:"X"}, xyzFormat);
        /// xOutput.format(4.5); // returns "X4.5"
        /// xOutput.format(4.5); // returns "" (4.5 is currently stored in the xOutput variable)
        /// </code>
        [Test]
        public void TestCreateFormat_createVariable_N2()
        {
            string testCode = @"var xyzFormat = createFormat({decimals:3, forceDecimal:true});
var xOutput = createVariable({prefix:""X""}, xyzFormat);
xOutput.format(4.5);";
            string expected = "";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<string>("xOutput.format(4.5)"));
        }

         /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-70</summary>
        /// <code>
        /// var xyzFormat = createFormat({decimals:3, forceDecimal:true});
        /// var xOutput = createVariable({prefix:"X"}, xyzFormat);
        /// xOutput.format(4.5); // returns "X4.5"
        /// xOutput.format(4.5); // returns "" (4.5 is currently stored in the xOutput variable)
        /// xOutput.reset(); // force xOuput on next formatting
        /// xOutput.format(4.5); // returns "X4.5"
        /// </code>
        [Test]
        public void TestCreateFormat_createVariable_N3()
        {
            string testCode = @"var xyzFormat = createFormat({decimals:3, forceDecimal:true});
var xOutput = createVariable({prefix:""X""}, xyzFormat);
xOutput.format(4.5);
xOutput.reset();";
            string expected = "X4.5";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<string>("xOutput.format(4.5)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-70</summary>
        /// <code>
        /// var xyzFormat = createFormat({decimals:3, forceDecimal:true});
        /// var xOutput = createVariable({prefix:"X"}, xyzFormat);
        /// xOutput.format(4.5); // returns "X4.5"
        /// xOutput.format(4.5); // returns "" (4.5 is currently stored in the xOutput variable)
        /// xOutput.reset(); // force xOuput on next formatting
        /// xOutput.format(4.5); // returns "X4.5"
        /// xOutput.disable(); // disable xOutput formatting
        /// xOutput.format(1.2); // returns "" since it is disabled
        /// </code>
        [Test]
        public void TestCreateFormat_createVariable_N4()
        {
            string testCode = @"var xyzFormat = createFormat({decimals:3, forceDecimal:true});
var xOutput = createVariable({prefix:""X""}, xyzFormat);
xOutput.format(4.5);
xOutput.reset();
xOutput.format(4.5);
xOutput.disable();";
            string expected = "";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual(expected, Fu360PostProcessor.engine.Evaluate<string>("xOutput.format(1.2)"));
        }

        /// <summary> example from "Post Processor Training Guide"(CAM Post Processor Guide 6/8/21) p.4-70</summary>
        /// <code>
        /// var gFormat = createFormat({prefix:"G", decimals:0, width:2, zeropad:true});
        /// var gMotionModal = createModal({force:true}, gFormat);
        /// gMotionModal.format(0); // returns G00
        /// gMotionModal.format(0); // returns G00 (force is set to 'true')
        /// gMotionModal.setPrefix("G1=");
        /// gMotionModal.setSuffix("*");
        /// gMotionModal.format(1); // returns "G1=01*"
        /// </code>
        [Test]
        public void TestCreateFormat_createModal()
        {
            string testCode = @"var gFormat = createFormat({prefix:""G"", decimals:0, width:2, zeropad:true});
 var gMotionModal = createModal({force:true}, gFormat);";
            var obj = new Fu360PostProcessor(testCode, false);
            Assert.AreEqual("G00", Fu360PostProcessor.engine.Evaluate<string>("gMotionModal.format(0)"));
            Assert.AreEqual("G00", Fu360PostProcessor.engine.Evaluate<string>("gMotionModal.format(0)"));
            Fu360PostProcessor.engine.Evaluate("gMotionModal.setPrefix(\"G1=\")");
            Fu360PostProcessor.engine.Evaluate("gMotionModal.setSuffix(\"*\")");
            Assert.AreEqual("G1=01*", Fu360PostProcessor.engine.Evaluate<string>("gMotionModal.format(1)"));
        }
    }
}