using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[Command(ProtocolName.Page.GetInstallabilityErrors)]
	[SupportedBy("Chrome")]
	public class GetInstallabilityErrorsCommand: ICommand<GetInstallabilityErrorsCommandResponse>
	{
	}
}
