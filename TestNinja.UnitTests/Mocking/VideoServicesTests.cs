using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServicesTests
    {
        private VideoService service;
        private Mock<IFileReader> fileReader;

        [SetUp]
        public void SetUp()
        {
            fileReader = new Mock<IFileReader>();            
            service = new VideoService(fileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var result = service.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
