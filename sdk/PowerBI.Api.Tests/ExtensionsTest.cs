using Microsoft.PowerBI.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace PowerBI.Api.Tests
{
    [TestClass]
    public class ExtensionsTest
    {
        [TestMethod]
        public void VerifyAllInGroupFunctionsHasMatchingOverrideWithoutInGroup()
        {
            Type[] expectedTypeWithInGroupVersions = { typeof(ReportsClient), typeof(DatasetsClient), typeof(DashboardsClient), typeof(TilesClient), typeof(DataflowsClient), typeof(ImportsClient) };
            string[] notOverridenMethods = { "DeleteUserInGroup", "DeleteUserInGroupAsync" };
            string[] expectedMethodsWithoutMyWorkspaceVersions = { "GenerateTokenForCreateInGroup", "GenerateTokenInGroup", "TakeOverInGroup", "GetUpstreamDataflowsInGroup", "GetDatasetToDataflowsLinksAsAdminInGroup", "GetDatasetToDataflowsLinksInGroup" };

            var allExtensionTypes = typeof(PowerBIClient).Assembly.GetTypes().Where(t => t.Name.EndsWith("Client") && !t.Name.Contains("Rest"));
            foreach (var type in allExtensionTypes)
            {
                if (expectedTypeWithInGroupVersions.Contains(type))
                {
                    TestInGroupOverrides(type, expectedMethodsWithoutMyWorkspaceVersions);
                }
                else
                {
                    var typeMethods = type.GetMethods().Where(mi => !notOverridenMethods.Contains(mi.Name));
                    Assert.IsTrue(typeMethods.All(mi => !mi.Name.Contains("InGroup")), "Types which were not added the override without InGroup, shouldn't have InGroup methods");
                }
            }
        }

        private void TestInGroupOverrides(Type type, string[] notOverridenMethods)
        {
            var allMethods = type.GetMethods();
            var inGroupMethods = allMethods.Where(mi => mi.Name.Contains("InGroup") && !notOverridenMethods.Any(substring => mi.Name.Contains(substring)));

            foreach (var inGroupMethod in inGroupMethods)
            {
                // Search method with the same name without InGroup, and with the same parameter list
                var nameWithoutInGroup = inGroupMethod.Name.Replace("InGroup", "");

                var overrideMethods = allMethods.Where(mi => mi.Name.Equals(nameWithoutInGroup));

                Assert.AreEqual(1, overrideMethods.Count(), "Expecting exactly one instance of mathcing method without InGroup suffix");
            }
        }

    }
}
