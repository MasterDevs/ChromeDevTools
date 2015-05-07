using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Sets the new stylesheet text.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetStyleSheetText)]
	public class SetStyleSheetTextCommandResponse
	{
	}
}
