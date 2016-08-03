using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	/// Data entry.
	/// </summary>
	[SupportedBy("iOS")]
	public class DataEntry
	{
		/// <summary>
		/// Gets or sets Key.
		/// </summary>
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Gets or sets Primary key.
		/// </summary>
		public Runtime.RemoteObject PrimaryKey { get; set; }
		/// <summary>
		/// Gets or sets Value.
		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
