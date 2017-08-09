using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Rendering
{
	/// <summary>
	/// Paints viewport size upon main frame resize.
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetShowViewportSizeOnResize)]
	[SupportedBy("Chrome")]
	public class SetShowViewportSizeOnResizeCommandResponse
	{
	}
}
