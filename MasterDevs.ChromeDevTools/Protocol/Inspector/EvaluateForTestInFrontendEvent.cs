using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	[Event(ProtocolName.Inspector.EvaluateForTestInFrontend)]
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
