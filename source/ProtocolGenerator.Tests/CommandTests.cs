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
        [DeploymentItem(DeploymentItems.Inspector11)]
        [DeploymentItem(DeploymentItems.BrowserProtocol)]
        [DeploymentItem(DeploymentItems.JsProtocol)]
        public void EqualsTest()
        {
            var inspector11 = ProtocolProcessor.LoadProtocol(new[] { DeploymentItems.Inspector11 }, "inspector-1.1");
            var protocol = ProtocolProcessor.LoadProtocol(new[] { DeploymentItems.BrowserProtocol, DeploymentItems.JsProtocol }, "protocol");

            ProtocolProcessor.ResolveTypeReferences(inspector11, new Dictionary<string, string>());
            ProtocolProcessor.ResolveTypeReferences(protocol, new Dictionary<string, string>());

            var stopScreencast10 = inspector11.GetDomain("Page").GetCommand("stopScreencast");
            var stopScreencastTip = protocol.GetDomain("Page").GetCommand("stopScreencast");

            // Quick fact check: both methods have the same string equivalent,
            // void stopScreencast()
            Assert.AreEqual<string>(stopScreencast10.ToString(), stopScreencastTip.ToString());

            Assert.IsTrue(stopScreencast10.Equals(stopScreencastTip));
            Assert.IsTrue(stopScreencastTip.Equals(stopScreencast10));
        }
    }
}
