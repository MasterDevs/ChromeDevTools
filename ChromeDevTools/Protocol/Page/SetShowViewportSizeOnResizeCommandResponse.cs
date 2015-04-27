using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Paints viewport size upon main frame resize.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetShowViewportSizeOnResize)]
	public class SetShowViewportSizeOnResizeCommandResponse
	{
	}
}
