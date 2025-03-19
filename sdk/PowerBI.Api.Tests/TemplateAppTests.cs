using System.Threading;
using System.Threading.Tasks;
using Azure;
using Microsoft.PowerBI.Api;
using Microsoft.PowerBI.Api.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace PowerBI.Api.Tests
{
    [TestClass]
    public class TemplateAppTests
    {
        [TestMethod]
        public async Task CreateInstallTicket()
        {
            // Create a mock response
            var mockResponse = new Mock<Response<InstallTicket>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            // Create a mock of PowerBIClient
            var mock = new Mock<PowerBIClient>();

            //Set up client method
            mock.Setup(x => x.TemplateApps.CreateInstallTicketAsync(It.IsAny<CreateInstallTicketRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mock.Object;
            var result = await client.TemplateApps.CreateInstallTicketAsync(It.IsAny<CreateInstallTicketRequest>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

    }
}
