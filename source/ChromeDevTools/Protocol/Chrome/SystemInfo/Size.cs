using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Describes the width and height dimensions of an entity.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Size
	{
		/// <summary>
		/// Gets or sets Width in pixels.
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Height in pixels.
		/// </summary>
		public long Height { get; set; }
	}
}
