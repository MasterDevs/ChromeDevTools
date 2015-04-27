using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Sets the new stylesheet text.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetStyleSheetText)]
	public class SetStyleSheetTextCommandResponse
	{
	}
}
