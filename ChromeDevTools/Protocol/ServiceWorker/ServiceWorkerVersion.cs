using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	/// <summary>
	/// ServiceWorker version.
	/// </summary>
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
		public double ScriptLastModified { get; set; }
		/// <summary>
		/// Gets or sets The time at which the response headers of the main script were received from the server.  For cached script it is the last time the cache entry was validated.
		/// </summary>
		public double ScriptResponseTime { get; set; }
	}
}
