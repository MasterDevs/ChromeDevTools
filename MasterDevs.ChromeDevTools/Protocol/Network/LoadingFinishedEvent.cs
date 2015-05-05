using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when HTTP request has finished loading.
	/// </summary>
	[Event(ProtocolName.Network.LoadingFinished)]
	public class LoadingFinishedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Total number of bytes received for this request.
		/// </summary>
		public double EncodedDataLength { get; set; }
	}
}
