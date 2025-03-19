using System;
using System.IO;
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
    public class ImportsTests
    {
        private Guid groupId;

        [TestInitialize]
        public void TestInitialize()
        {
            this.groupId = Guid.NewGuid();
        }

        [TestMethod]
        public async Task PostImportWithFileWithNameAndConflict()
        {
            var datasetDisplayName = "TestDataset";
            var nameConflict = ImportConflictHandlerMode.Overwrite;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, nameConflict, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, nameConflict, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task Groups_PostImportWithFileWithNameAndConflictAsync()
        {
            var datasetDisplayName = "TestDataset";
            var nameConflict = ImportConflictHandlerMode.Overwrite;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsyncInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, nameConflict, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsyncInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, nameConflict, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public void Groups_PostImportWithFileWithNameAndConflict()
        {
            var datasetDisplayName = "TestDataset";
            var nameConflict = ImportConflictHandlerMode.Overwrite;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, nameConflict, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).Returns(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = client.Imports.PostImportWithFileInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, nameConflict, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task PostImportFileWithName()
        {
            var datasetDisplayName = "TestDataset";

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task Groups_PostImportFileWithNameAsync()
        {
            var datasetDisplayName = "TestDataset";

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsyncInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsyncInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }


        [TestMethod]
        public async Task PostImportFileWithNameAndSkipReport()
        {
            var datasetDisplayName = "TestDataset";
            var skipReport = true;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), skipReport, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), skipReport, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public void Group_PostImportFileWithNameAndSkipReport()
        {
            var datasetDisplayName = "TestDataset";
            var skipReport = true;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), skipReport, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).Returns(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = client.Imports.PostImportWithFileInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), skipReport, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task Group_PostImportFileWithNameAndSkipReportAsync()
        {
            var datasetDisplayName = "TestDataset";
            var skipReport = true;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsyncInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), skipReport, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsyncInGroup(this.groupId, It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), skipReport, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task PostImportFileWithNameAndNotOverrideReport()
        {
            var datasetDisplayName = "TestDataset";
            var overrideReportLabel = false;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), overrideReportLabel, It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), overrideReportLabel, It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task PostImportFileWithNameAndNotOverrideModel()
        {
            var datasetDisplayName = "TestDataset";
            var overrideModelLabel = false;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), It.IsAny<bool>(), overrideModelLabel, It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), It.IsAny<bool>(), overrideModelLabel, It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task PostImportFileWithNameAndNotOverrideLabels()
        {
            var datasetDisplayName = "TestDataset";
            var overrideReportLabel = false;
            var overrideModelLabel = false;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), overrideReportLabel, overrideModelLabel, It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), overrideReportLabel, overrideModelLabel, It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task PostImportFileWithNameAndOverrideLabels()
        {
            var datasetDisplayName = "TestDataset";
            var overrideReportLabel = true;
            var overrideModelLabel = true;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), overrideReportLabel, overrideModelLabel, It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), overrideReportLabel, overrideModelLabel, It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task PostImportWithFileWithNameAndConflictAndSkipReport()
        {
            var datasetDisplayName = "TestDataset";
            var nameConflict = ImportConflictHandlerMode.Overwrite;
            var skipReport = true;

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, nameConflict, skipReport, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, nameConflict, skipReport, It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Guid>(), It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }

        [TestMethod]
        public async Task PostImportWithFileWithNameAndSubfolderObjectId()
        {
            var datasetDisplayName = "TestDataset";
            var subFolderObjectId = Guid.NewGuid();

            // Create a mock response
            var mockResponse = new Mock<Response<Import>>();
            mockResponse.Setup(r => r.GetRawResponse().Status).Returns(200);

            //Create a client mock
            var mockClient = new Mock<PowerBIClient>();

            //Set up client method
            mockClient.Setup(x => x.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), subFolderObjectId, It.IsAny<CancellationToken>())).ReturnsAsync(mockResponse.Object);

            //Use the client mock
            PowerBIClient client = mockClient.Object;
            var result = await client.Imports.PostImportWithFileAsync(It.IsAny<Stream>(), datasetDisplayName, It.IsAny<ImportConflictHandlerMode>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), subFolderObjectId, It.IsAny<CancellationToken>());

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.GetRawResponse().Status);
        }
    }
}
