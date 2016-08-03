using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	/// <summary>
	/// Database object.
	/// </summary>
	[SupportedBy("iOS")]
	public class Database
	{
		/// <summary>
		/// Gets or sets Database ID.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Database domain.
		/// </summary>
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Database version.
		/// </summary>
		public string Version { get; set; }
	}
}
