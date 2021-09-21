using System;
using MasterDevs.ChromeDevTools.Protocol.iOS.DOM;

using System.IO;
using NUnit.Framework;

namespace MasterDevs.ChromeDevTools.Tests
{
    [TestFixture]
    public class CommandResponseFactoryTests
    {
        [Test]
        public void CreateTest()
        {
            string json = File.ReadAllText("response-1.json");

            MethodTypeMap map = new MethodTypeMap("iOS");
            CommandFactory commandFactory = new CommandFactory();
            CommandResponseFactory responseFactory = new CommandResponseFactory(map, commandFactory);

            var command = commandFactory.Create<GetDocumentCommand>();
            var response = responseFactory.Create(json);

            Assert.IsInstanceOf<CommandResponse<GetDocumentCommandResponse>>(response);

            var responseTyped = (CommandResponse<GetDocumentCommandResponse>)response;

            Assert.AreEqual(1, responseTyped.Id);
            Assert.IsNotNull(responseTyped.Result);
        }
    }
}
