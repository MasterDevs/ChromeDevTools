using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Set default font sizes.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetFontSizes)]
	[SupportedBy("Chrome")]
	public class SetFontSizesCommandResponse
	{
	}
}
