using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	[SupportedBy("iOS")]
	public class Size
	{
		/// <summary>
		/// Gets or sets Width
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Height
		/// </summary>
		public long Height { get; set; }
	}
}
