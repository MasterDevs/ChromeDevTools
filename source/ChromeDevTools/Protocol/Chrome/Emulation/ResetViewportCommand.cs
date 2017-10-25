using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Resets the visible area of the page to the original viewport, undoing any effects of the <code>forceViewport</code> command.
	/// </summary>
	[Command(ProtocolName.Emulation.ResetViewport)]
	[SupportedBy("Chrome")]
	public class ResetViewportCommand: ICommand<ResetViewportCommandResponse>
	{
	}
}
