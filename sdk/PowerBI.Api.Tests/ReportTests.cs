using System;
using System.Threading.Tasks;
using Microsoft.PowerBI.Api;
using Microsoft.PowerBI.Api.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Azure;
using Moq;
using System.Threading;

namespace PowerBI.Api.Tests
{
    [TestClass]
    public class ReportTests
    {
        [TestMethod]
        public async Task ReportDelete()
        {
            // Create a mock response 
            var mockResponse = new Mock<Response>();
            mockResponse.Setup(r => r.Status).Returns(200);

            // Create a mock of PowerBIClient
            var mockClient = new Mock<PowerBIClient>();

            // Set up client method
            mockClient.Setup(x => x.Reports.DeleteReportAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            // Use the client mock
            var client = mockClient.Object;
            var result = await client.Reports.DeleteReportAsync(It.IsAny<Guid>());

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.Status);
        }

        [TestMethod]
        public async Task ReportDeleteInGroup()
        {
            // Create a mock response 
            var mockResponse = new Mock<Response>();
            mockResponse.Setup(r => r.Status).Returns(200);

            // Create a mock of PowerBIClient
            var mockClient = new Mock<PowerBIClient>();

            // Set up client method
            mockClient.Setup(x => x.Reports.DeleteReportInGroupAsync(It.IsAny<Guid>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            // Use the client mock
            var client = mockClient.Object;
            var result = await client.Reports.DeleteReportInGroupAsync(It.IsAny<Guid>(), It.IsAny<Guid>());

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.Status);
        }

        [TestMethod]
        public async Task ReportRebind()
        {
            // Create a mock response
            var mockResponse = new Mock<Response>();
            mockResponse.Setup(r => r.Status).Returns(200);

            // Create a mock value
            var mockValue = MicrosoftPowerBIApiModelFactory.Reports();

            // Create a mock of PowerBIClient
            var mock = new Mock<PowerBIClient>();

            //Set up client method
            mock.Setup(x => x.Reports.RebindReportAsync(It.IsAny<Guid>(), It.IsAny<RebindReportRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mock.Object;
            var result = await client.Reports.RebindReportAsync(It.IsAny<Guid>(), It.IsAny<RebindReportRequest>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.Status);
        }

        [TestMethod]
        public async Task ReportClone()
        {
            // Create a mock response
            var mockResponse = new Mock<Response<Report>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            // Create a mock value
            var mockValue = MicrosoftPowerBIApiModelFactory.Reports();

            // Create a mock of PowerBIClient
            var mock = new Mock<PowerBIClient>();

            //Set up client method
            mock.Setup(x => x.Reports.CloneReportAsync(It.IsAny<Guid>(), It.IsAny<CloneReportRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mock.Object;
            var result = await client.Reports.CloneReportAsync(It.IsAny<Guid>(), It.IsAny<CloneReportRequest>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);

        }

        [TestMethod]
        public async Task UpdateReportContent()
        {
            // Create a mock response
            var mockResponse = new Mock<Response<Report>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            // Create a mock value
            var mockValue = MicrosoftPowerBIApiModelFactory.Reports();

            // Create a mock of PowerBIClient
            var mock = new Mock<PowerBIClient>();

            //Set up client method
            mock.Setup(x => x.Reports.UpdateReportContentAsync(It.IsAny<Guid>(), It.IsAny<UpdateReportContentRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mock.Object;
            var result = await client.Reports.UpdateReportContentAsync(It.IsAny<Guid>(), It.IsAny<UpdateReportContentRequest>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }
    }
}
