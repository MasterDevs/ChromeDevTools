using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Database with an array of object stores.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DatabaseWithObjectStores
	{
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Database version (type is not 'integer', as the standard
		/// requires the version number to be 'unsigned long long')
		/// </summary>
		public double Version { get; set; }
		/// <summary>
		/// Gets or sets Object stores in this database.
		/// </summary>
		public ObjectStore[] ObjectStores { get; set; }
	}
}
