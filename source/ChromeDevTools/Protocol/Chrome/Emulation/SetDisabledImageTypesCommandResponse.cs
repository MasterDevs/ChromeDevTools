using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[CommandResponse(ProtocolName.Emulation.SetDisabledImageTypes)]
	[SupportedBy("Chrome")]
	public class SetDisabledImageTypesCommandResponse
	{
	}
}
