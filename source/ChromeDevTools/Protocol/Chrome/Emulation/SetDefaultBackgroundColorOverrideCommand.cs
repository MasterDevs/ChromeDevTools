using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Sets or clears an override of the default background color of the frame. This override is used if the content does not specify one.
	/// </summary>
	[Command(ProtocolName.Emulation.SetDefaultBackgroundColorOverride)]
	[SupportedBy("Chrome")]
	public class SetDefaultBackgroundColorOverrideCommand: ICommand<SetDefaultBackgroundColorOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets RGBA of the default background color. If not specified, any existing override will be cleared.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA Color { get; set; }
	}
}
