using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	[Event(ProtocolName.Inspector.EvaluateForTestInFrontend)]
	[SupportedBy("iOS")]
	public class EvaluateForTestInFrontendEvent
	{
		/// <summary>
		/// Gets or sets Script
		/// </summary>
		public string Script { get; set; }
	}
}
