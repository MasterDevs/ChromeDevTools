using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Timing information for the request.
	/// </summary>
	[SupportedBy("iOS")]
	public class ResourceTiming
	{
		/// <summary>
		/// Gets or sets Timing's navigationStart is a baseline in seconds, while the other numbers are ticks in milliseconds relatively to this navigationStart.
		/// </summary>
		public double NavigationStart { get; set; }
		/// <summary>
		/// Gets or sets Started DNS address resolve.
		/// </summary>
		public double DomainLookupStart { get; set; }
		/// <summary>
		/// Gets or sets Finished DNS address resolve.
		/// </summary>
		public double DomainLookupEnd { get; set; }
		/// <summary>
		/// Gets or sets Started connecting to the remote host.
		/// </summary>
		public double ConnectStart { get; set; }
		/// <summary>
		/// Gets or sets Connected to the remote host.
		/// </summary>
		public double ConnectEnd { get; set; }
		/// <summary>
		/// Gets or sets Started SSL handshake.
		/// </summary>
		public double SecureConnectionStart { get; set; }
		/// <summary>
		/// Gets or sets Started sending request.
		/// </summary>
		public double RequestStart { get; set; }
		/// <summary>
		/// Gets or sets Started receiving response headers.
		/// </summary>
		public double ResponseStart { get; set; }
	}
}
