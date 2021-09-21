using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	[SupportedBy("Chrome")]
	public class BackgroundServiceEvent
	{
		/// <summary>
		/// Gets or sets Timestamp of the event (in seconds).
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets The origin this event belongs to.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets The Service Worker ID that initiated the event.
		/// </summary>
		public string ServiceWorkerRegistrationId { get; set; }
		/// <summary>
		/// Gets or sets The Background Service this event belongs to.
		/// </summary>
		public ServiceName Service { get; set; }
		/// <summary>
		/// Gets or sets A description of the event.
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets An identifier that groups related events together.
		/// </summary>
		public string InstanceId { get; set; }
		/// <summary>
		/// Gets or sets A list of event-specific information.
		/// </summary>
		public EventMetadata[] EventMetadata { get; set; }
	}
}
