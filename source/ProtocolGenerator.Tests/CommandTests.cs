
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator.Tests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
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
            Assert.AreEqual(stopScreencast10.ToString(), stopScreencastTip.ToString());

            Assert.IsTrue(stopScreencast10.Equals(stopScreencastTip));
            Assert.IsTrue(stopScreencastTip.Equals(stopScreencast10));
        }
    }
}
