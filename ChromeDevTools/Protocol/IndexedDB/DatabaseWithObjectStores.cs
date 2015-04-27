using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Database with an array of object stores.
	/// </summary>
	public class DatabaseWithObjectStores
	{
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Deprecated string database version.
		/// </summary>
		public string Version { get; set; }
		/// <summary>
		/// Gets or sets Integer database version.
		/// </summary>
		public long IntVersion { get; set; }
		/// <summary>
		/// Gets or sets Object stores in this database.
		/// </summary>
		public ObjectStore[] ObjectStores { get; set; }
	}
}
