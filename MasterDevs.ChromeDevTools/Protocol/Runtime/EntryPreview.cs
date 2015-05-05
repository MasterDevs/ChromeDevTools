using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// 
	/// </summary>
	public class EntryPreview
	{
		/// <summary>
		/// Gets or sets Preview of the key. Specified for map-like collection entries.
		/// </summary>
		public ObjectPreview Key { get; set; }
		/// <summary>
		/// Gets or sets Preview of the value.
		/// </summary>
		public ObjectPreview Value { get; set; }
	}
}
