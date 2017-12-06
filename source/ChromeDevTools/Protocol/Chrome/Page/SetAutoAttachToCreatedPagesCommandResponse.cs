using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Controls whether browser will open a new inspector window for connected pages.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetAutoAttachToCreatedPages)]
	[SupportedBy("Chrome")]
	public class SetAutoAttachToCreatedPagesCommandResponse
	{
	}
}
