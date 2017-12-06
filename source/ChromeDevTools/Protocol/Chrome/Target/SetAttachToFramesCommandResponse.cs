using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	[CommandResponse(ProtocolName.Target.SetAttachToFrames)]
	[SupportedBy("Chrome")]
	public class SetAttachToFramesCommandResponse
	{
	}
}
