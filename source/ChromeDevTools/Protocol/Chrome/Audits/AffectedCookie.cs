using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Information about a cookie that is affected by an inspector issue.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AffectedCookie
	{
		/// <summary>
		/// Gets or sets The following three properties uniquely identify a cookie
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Path
		/// </summary>
		public string Path { get; set; }
		/// <summary>
		/// Gets or sets Domain
		/// </summary>
		public string Domain { get; set; }
	}
}
