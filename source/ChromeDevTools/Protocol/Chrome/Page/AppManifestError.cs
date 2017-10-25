using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Error while paring app manifest.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AppManifestError
	{
		/// <summary>
		/// Gets or sets Error message.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets If criticial, this is a non-recoverable parse error.
		/// </summary>
		public long Critical { get; set; }
		/// <summary>
		/// Gets or sets Error line.
		/// </summary>
		public long Line { get; set; }
		/// <summary>
		/// Gets or sets Error column.
		/// </summary>
		public long Column { get; set; }
	}
}
