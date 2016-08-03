using System;
using MasterDevs.ChromeDevTools.Protocol.iOS.DOM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace MasterDevs.ChromeDevTools.Tests
{
    [TestClass]
    public class CommandResponseFactoryTests
    {
        [TestMethod]
        [DeploymentItem("response-1.json")]
        public void CreateTest()
        {
            string json = File.ReadAllText("response-1.json");

            MethodTypeMap map = new MethodTypeMap("iOS");
            CommandFactory commandFactory = new CommandFactory();
            CommandResponseFactory responseFactory = new CommandResponseFactory(map, commandFactory);

            var command = commandFactory.Create<GetDocumentCommand>();
            var response = responseFactory.Create(json);

            Assert.IsInstanceOfType(response, typeof(CommandResponse<GetDocumentCommandResponse>));

            var responseTyped = (CommandResponse<GetDocumentCommandResponse>)response;

            Assert.AreEqual(1, responseTyped.Id);
            Assert.IsNotNull(responseTyped.Result);
        }
    }
}
