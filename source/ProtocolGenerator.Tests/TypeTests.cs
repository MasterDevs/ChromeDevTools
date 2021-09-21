
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator.Tests
{
    [TestFixture]
    public class TypeTests
    {

        [Test]
        public void TypeNameTest()
        {
            Protocol p = ProtocolProcessor.LoadProtocol(new[] { DeploymentItems.Inspector10 }, "Chrome-1.0");

            var evaluateCommand = p.GetDomain("Page").GetCommand("searchInResource");
            var result = evaluateCommand.Returns.Single();

            Assert.AreEqual("SearchMatch[]", result.TypeName.ToString());
        }

        [Test]
        public void ToStringTest()
        {
            Protocol p = ProtocolProcessor.LoadProtocol(new[] { DeploymentItems.Inspector10 }, "Chrome-1.0");

            var evaluateCommand = p.GetDomain("Page").GetCommand("searchInResource");
            var result = evaluateCommand.Returns.Single();
            var items = result.Items;

            Assert.AreEqual("SearchMatch", items.ToString());
        }
    }
}
