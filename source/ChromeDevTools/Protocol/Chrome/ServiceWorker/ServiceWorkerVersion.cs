using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	/// <summary>
	/// ServiceWorker version.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ServiceWorkerVersion
	{
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		public string VersionId { get; set; }
		/// <summary>
		/// Gets or sets RegistrationId
		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets ScriptURL
		/// </summary>
		public string ScriptURL { get; set; }
		/// <summary>
		/// Gets or sets RunningStatus
		/// </summary>
		public ServiceWorkerVersionRunningStatus RunningStatus { get; set; }
		/// <summary>
		/// Gets or sets Status
		/// </summary>
		public ServiceWorkerVersionStatus Status { get; set; }
		/// <summary>
		/// Gets or sets The Last-Modified header value of the main script.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScriptLastModified { get; set; }
		/// <summary>
		/// Gets or sets The time at which the response headers of the main script were received from the server.  For cached script it is the last time the cache entry was validated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScriptResponseTime { get; set; }
		/// <summary>
		/// Gets or sets ControlledClients
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] ControlledClients { get; set; }
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
