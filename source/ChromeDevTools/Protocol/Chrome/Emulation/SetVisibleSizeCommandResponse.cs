using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Resizes the frame/viewport of the page. Note that this does not affect the frame's container (e.g. browser window). Can be used to produce screenshots of the specified size. Not supported on Android.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Emulation.SetVisibleSize)]
	[SupportedBy("Chrome")]
	public class SetVisibleSizeCommandResponse
	{
	}
}
