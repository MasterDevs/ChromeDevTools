using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Enables/disables rendering of local CSS fonts (enabled by default).
	/// </summary>
	[Command(ProtocolName.CSS.SetLocalFontsEnabled)]
	[SupportedBy("Chrome")]
	public class SetLocalFontsEnabledCommand: ICommand<SetLocalFontsEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether rendering of local fonts is enabled.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
