using MasterDevs.ChromeDevTools.Protocol.Chrome.DOM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Tests
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void ShadowRootTypeTest()
        {
            var value = JsonConvert.DeserializeObject<ShadowRootType>("\"user-agent\"");
        }
    }
}
