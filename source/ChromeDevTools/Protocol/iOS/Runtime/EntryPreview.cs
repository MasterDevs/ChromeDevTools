using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS")]
	public class EntryPreview
	{
		/// <summary>
		/// Gets or sets Entry key. Specified for map-like collection entries.
		/// </summary>
		public ObjectPreview Key { get; set; }
		/// <summary>
		/// Gets or sets Entry value.
		/// </summary>
		public ObjectPreview Value { get; set; }
	}
}
