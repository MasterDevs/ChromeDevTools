using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Paints viewport size upon main frame resize.
	/// </summary>
	[Command(ProtocolName.Page.SetShowViewportSizeOnResize)]
	public class SetShowViewportSizeOnResizeCommand
	{
		/// <summary>
		/// Gets or sets Whether to paint size or not.
		/// </summary>
		public bool Show { get; set; }
		/// <summary>
		/// Gets or sets Whether to paint grid as well.
		/// </summary>
		public bool ShowGrid { get; set; }
	}
}
