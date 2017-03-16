using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Data entry.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DataEntry
	{
		/// <summary>
		/// Gets or sets Key object.
		/// </summary>
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Gets or sets Primary key object.
		/// </summary>
		public Runtime.RemoteObject PrimaryKey { get; set; }
		/// <summary>
		/// Gets or sets Value object.
		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
