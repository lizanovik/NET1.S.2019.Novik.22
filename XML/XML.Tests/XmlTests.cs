using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using XML.Contracts;
using XML.Implementation.Implementations;
using XML.Interfaces;

namespace XML.Tests
{
    [TestFixture]
    public class XmlTests
    {
        [Test]
        public void DataRetrieverMockTest()
        {
            Mock<IDataRetriever> mock = new Mock<IDataRetriever>();
            mock.Setup(p => p.LoadData());
            IDataRetriever retriever = mock.Object;
            retriever.LoadData();
            mock.Verify(pr => pr.LoadData());
        }


        [Test]
        public void LoggerMockTest()
        {
            Mock<ILogger> mock = new Mock<ILogger>();
            mock.Setup(p => p.Trace(It.IsAny<string>()));
            ILogger logger = mock.Object;
            logger.Trace("darova");
            mock.Verify(pr => pr.Trace("darova"));
        }

    }
}
