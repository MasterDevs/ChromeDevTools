using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[Command(ProtocolName.Page.GetAppManifest)]
	[SupportedBy("Chrome")]
	public class GetAppManifestCommand: ICommand<GetAppManifestCommandResponse>
	{
	}
}
