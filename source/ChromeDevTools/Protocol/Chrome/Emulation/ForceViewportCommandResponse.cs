using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides the visible area of the page. The change is hidden from the page, i.e. the observable scroll position and page scale does not change. In effect, the command moves the specified area of the page into the top-left corner of the frame.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.ForceViewport)]
	[SupportedBy("Chrome")]
	public class ForceViewportCommandResponse
	{
	}
}
