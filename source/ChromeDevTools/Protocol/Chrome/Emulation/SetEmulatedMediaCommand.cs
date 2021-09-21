using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Emulates the given media type or media feature for CSS media queries.
	/// </summary>
	[Command(ProtocolName.Emulation.SetEmulatedMedia)]
	[SupportedBy("Chrome")]
	public class SetEmulatedMediaCommand: ICommand<SetEmulatedMediaCommandResponse>
	{
		/// <summary>
		/// Gets or sets Media type to emulate. Empty string disables the override.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Media { get; set; }
		/// <summary>
		/// Gets or sets Media features to emulate.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public MediaFeature[] Features { get; set; }
	}
}
