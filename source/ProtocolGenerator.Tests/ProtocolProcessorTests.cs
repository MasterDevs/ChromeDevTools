using System;
using System.Linq;

using System.Collections.Generic;
using NUnit.Framework;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator.Tests
{
    [TestFixture]
    public class ProtocolProcessorTests
    {
        /// <summary>
        /// Loads the Chrome-1.0 protocol and makes sure the type <c>Network.FrameId</c> type reference in the
        /// <c>Runtime.Evaluate</c> command is resolved correctly to the <c>string</c> primitive.
        /// </summary>
        [Test]
        public void ResolveTypeReferencesCommandParameterTest()
        {
            Protocol p = ProtocolProcessor.LoadProtocol(new[] { DeploymentItems.Inspector10 }, "Chrome-1.0");
            ProtocolProcessor.ResolveTypeReferences(p, new Dictionary<string, string>());

            var evaluateCommand = p.GetDomain("Runtime").GetCommand("evaluate");
            var frameIdParameter = evaluateCommand.GetParameter("frameId");

            Assert.AreEqual("string", frameIdParameter.TypeName);
        }

        [Test]
        public void ResolveTypeReferencesCommandParameterTest2()
        {
            Protocol p = ProtocolProcessor.LoadProtocol(new[] { DeploymentItems.Inspector10 }, "Chrome-1.0");
            ProtocolProcessor.ResolveTypeReferences(p, new Dictionary<string, string>());

            var addInspectedNodeCommand = p.GetDomain("Console").GetCommand("addInspectedNode");
            var nodeId = addInspectedNodeCommand.GetParameter("nodeId");

            Assert.AreEqual("integer", nodeId.TypeName);
        }

        [Test]
        public void ResolveTypeReferencesCommandReturnValueTest()
        {
            Dictionary<string, string> explicitMappings = new Dictionary<string, string>();
            explicitMappings.Add("Page.Cookie", "Network.Cookie");

            Protocol p = ProtocolProcessor.LoadProtocol(new[] { DeploymentItems.InspectoriOS8 }, "iOS-8.0");
            ProtocolProcessor.ResolveTypeReferences(p, explicitMappings);

            var getCookiesCommand = p.GetDomain("Page").GetCommand("getCookies");
            var cookieArray = getCookiesCommand.Returns.Single();

            Assert.AreEqual("Network.Cookie[]", cookieArray.TypeName);
        }

        [Test]
        public void ResolveTypeReferencesCommandReturnValueTest2()
        {
            Dictionary<string, string> explicitMappings = new Dictionary<string, string>();
            explicitMappings.Add("GenericTypes.SearchMatch", "Debugger.SearchMatch");

            Protocol p = ProtocolProcessor.LoadProtocol(new[] { DeploymentItems.InspectoriOS8 }, "iOS-8.0");
            ProtocolProcessor.ResolveTypeReferences(p, explicitMappings);

            var searchInResourceCommand = p.GetDomain("Page").GetCommand("searchInResource");
            var searchMatchArray = searchInResourceCommand.Returns.Single();

            Assert.AreEqual("Debugger.SearchMatch[]", searchMatchArray.TypeName);
        }
    }
}
