using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        [DeploymentItem(DeploymentItems.Inspector10)]
        [DeploymentItem(DeploymentItems.Protocol)]
        public void EqualsTest()
        {
            var inspector10 = ProtocolProcessor.LoadProtocol(DeploymentItems.Inspector10, "inspector-1.0");
            var protocol = ProtocolProcessor.LoadProtocol(DeploymentItems.Protocol, "protocol");

            ProtocolProcessor.ResolveTypeReferences(inspector10);
            ProtocolProcessor.ResolveTypeReferences(protocol);

            var searchInResource10 = inspector10.GetDomain("Page").GetCommand("searchInResource");
            var searchInResourceTip = protocol.GetDomain("Page").GetCommand("searchInResource");

            // Quick fact check: both methods have the same string equivalent,
            // ([] result) searchInResource(string frameId, string url, string query, boolean caseSensitive, boolean isRegex)
            Assert.AreEqual<string>(searchInResource10.ToString(), searchInResourceTip.ToString());

            // The result is a type, check whether the type has the same properties
            var result10 = searchInResource10.Returns.Single();
            var resultTip = searchInResourceTip.Returns.Single();

            Assert.IsTrue(result10.Equals(resultTip));

            Assert.IsTrue(searchInResource10.Equals(searchInResourceTip));
            Assert.IsTrue(searchInResourceTip.Equals(searchInResource10));
        }
    }
}
