using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Usage for a storage type.
	/// </summary>
	[SupportedBy("Chrome")]
	public class UsageForType
	{
		/// <summary>
		/// Gets or sets Name of storage type.
		/// </summary>
		public StorageType StorageType { get; set; }
		/// <summary>
		/// Gets or sets Storage usage (bytes).
		/// </summary>
		public double Usage { get; set; }
	}
}
