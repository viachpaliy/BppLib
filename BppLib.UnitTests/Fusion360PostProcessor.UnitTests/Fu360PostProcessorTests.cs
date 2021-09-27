using NUnit.Framework;
using Jurassic;
using Fusion360PostProcessor;

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

    }
}