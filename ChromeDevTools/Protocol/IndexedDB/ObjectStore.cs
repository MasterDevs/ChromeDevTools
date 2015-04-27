using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Object store.
	/// </summary>
	public class ObjectStore
	{
		/// <summary>
		/// Gets or sets Object store name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Object store key path.
		/// </summary>
		public KeyPath KeyPath { get; set; }
		/// <summary>
		/// Gets or sets If true, object store has auto increment flag set.
		/// </summary>
		public bool AutoIncrement { get; set; }
		/// <summary>
		/// Gets or sets Indexes in this object store.
		/// </summary>
		public ObjectStoreIndex[] Indexes { get; set; }
	}
}
