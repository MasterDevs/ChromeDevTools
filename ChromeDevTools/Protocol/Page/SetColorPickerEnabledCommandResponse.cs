using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Shows / hides color picker
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetColorPickerEnabled)]
	public class SetColorPickerEnabledCommandResponse
	{
	}
}
