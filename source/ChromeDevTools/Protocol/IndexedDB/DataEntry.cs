using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Data entry.
	/// </summary>
	public class DataEntry
	{
		/// <summary>
		/// Gets or sets JSON-stringified key object.
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets JSON-stringified primary key object.
		/// </summary>
		public string PrimaryKey { get; set; }
		/// <summary>
		/// Gets or sets JSON-stringified value object.
		/// </summary>
		public string Value { get; set; }
	}
}
