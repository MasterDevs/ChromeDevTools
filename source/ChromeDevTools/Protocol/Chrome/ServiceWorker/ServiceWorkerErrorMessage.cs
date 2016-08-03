using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	/// <summary>
	/// ServiceWorker error message.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ServiceWorkerErrorMessage
	{
		/// <summary>
		/// Gets or sets ErrorMessage
		/// </summary>
		public string ErrorMessage { get; set; }
		/// <summary>
		/// Gets or sets RegistrationId
		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		public string VersionId { get; set; }
		/// <summary>
		/// Gets or sets SourceURL
		/// </summary>
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets LineNumber
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets ColumnNumber
		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
