using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Shows / hides color picker
	/// </summary>
	[Command(ProtocolName.Page.SetColorPickerEnabled)]
	[SupportedBy("Chrome")]
	public class SetColorPickerEnabledCommand
	{
		/// <summary>
		/// Gets or sets Shows / hides color picker
		/// </summary>
		public bool Enabled { get; set; }
	}
}
