using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Configures overlay.
	/// </summary>
	[Command(ProtocolName.Page.ConfigureOverlay)]
	[SupportedBy("Chrome")]
	public class ConfigureOverlayCommand
	{
		/// <summary>
		/// Gets or sets Whether overlay should be suspended and not consume any resources.
		/// </summary>
		public bool Suspended { get; set; }
		/// <summary>
		/// Gets or sets Overlay message to display.
		/// </summary>
		public string Message { get; set; }
	}
}
