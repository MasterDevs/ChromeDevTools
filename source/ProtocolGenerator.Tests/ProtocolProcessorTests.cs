using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator.Tests
{
    [TestClass]
    public class ProtocolProcessorTests
    {
        /// <summary>
        /// Loads the Chrome-1.0 protocol and makes sure the type <c>Network.FrameId</c> type reference in the
        /// <c>Runtime.Evaluate</c> command is resolved correctly to the <c>string</c> primitive.
        /// </summary>
        [TestMethod]
        [DeploymentItem(DeploymentItems.Inspector10)]
        public void ResolveTypeReferencesTest()
        {
            Protocol p = ProtocolProcessor.LoadProtocol(DeploymentItems.Inspector10, "Chrome-1.0");
            ProtocolProcessor.ResolveTypeReferences(p);

            var evaluateCommand = p.GetDomain("Runtime").GetCommand("evaluate");
            var frameIdParameter = evaluateCommand.GetParameter("frameId");

            Assert.AreEqual("string", frameIdParameter.TypeName);
        }
    }
}
