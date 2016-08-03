using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	/// <summary>
	/// Enables Canvas inspection.
	/// </summary>
	[Command(ProtocolName.Canvas.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand
	{
	}
}
