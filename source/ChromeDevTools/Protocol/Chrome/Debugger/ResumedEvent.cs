using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Fired when the virtual machine resumed execution.
	/// </summary>
	[Event(ProtocolName.Debugger.Resumed)]
	[SupportedBy("Chrome")]
	public class ResumedEvent
	{
	}
}
