using MasterDevs.ChromeDevTools.Protocol.Chrome.DOM;

using Newtonsoft.Json;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime;
using NUnit.Framework;

namespace MasterDevs.ChromeDevTools.Tests
{
    [TestFixture]
    public class SerializationTests
    {
        [Test]
        public void ShadowRootTypeTest()
        {
            // Makes sure the "user-agent" property in the ShadowRootType class is serialized as "user-agent" and not
            // as "userAgent"
            var value = JsonConvert.DeserializeObject<ShadowRootType>("\"user-agent\"");
        }

        [Test]
        public void RunScriptCommandTest()
        {
            // The RunScriptCommand class has optional, non-nullable properties. This test makes sure they
            // actually are nullable, and are not serialized if no explicit value is given.
            var runScriptCommand = new RunScriptCommand();
            var value = JsonConvert.SerializeObject(runScriptCommand);

            // The only required parameter is ScriptId, so that's the only value which should be visible
            // when using default serialization.
            Assert.AreEqual("{\"ScriptId\":null}", value);
        }
    }
}
