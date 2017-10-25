using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Layout viewport position and dimensions.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LayoutViewport
	{
		/// <summary>
		/// Gets or sets Horizontal offset relative to the document (CSS pixels).
		/// </summary>
		public long PageX { get; set; }
		/// <summary>
		/// Gets or sets Vertical offset relative to the document (CSS pixels).
		/// </summary>
		public long PageY { get; set; }
		/// <summary>
		/// Gets or sets Width (CSS pixels), excludes scrollbar if present.
		/// </summary>
		public long ClientWidth { get; set; }
		/// <summary>
		/// Gets or sets Height (CSS pixels), excludes scrollbar if present.
		/// </summary>
		public long ClientHeight { get; set; }
	}
}
