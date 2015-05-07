using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Collection entry.
	/// </summary>
	public class CollectionEntry
	{
		/// <summary>
		/// Gets or sets Entry key of a map-like collection, otherwise not provided.
		/// </summary>
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Gets or sets Entry value.
		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
