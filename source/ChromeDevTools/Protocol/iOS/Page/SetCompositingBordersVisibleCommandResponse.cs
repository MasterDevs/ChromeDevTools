using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Controls the visibility of compositing borders.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetCompositingBordersVisible)]
	[SupportedBy("iOS")]
	public class SetCompositingBordersVisibleCommandResponse
	{
	}
}
