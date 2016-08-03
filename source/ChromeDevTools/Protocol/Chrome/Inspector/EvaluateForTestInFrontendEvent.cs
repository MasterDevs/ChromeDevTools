using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Inspector
{
	[Event(ProtocolName.Inspector.EvaluateForTestInFrontend)]
	[SupportedBy("Chrome")]
	public class EvaluateForTestInFrontendEvent
	{
		/// <summary>
		/// Gets or sets TestCallId
		/// </summary>
		public long TestCallId { get; set; }
		/// <summary>
		/// Gets or sets Script
		/// </summary>
		public string Script { get; set; }
	}
}
