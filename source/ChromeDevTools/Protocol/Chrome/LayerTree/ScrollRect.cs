using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Rectangle where scrolling happens on the main thread.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScrollRect
	{
		/// <summary>
		/// Gets or sets Rectangle itself.
		/// </summary>
		public DOM.Rect Rect { get; set; }
		/// <summary>
		/// Gets or sets Reason for rectangle to force scrolling on the main thread
		/// </summary>
		public string Type { get; set; }
	}
}
