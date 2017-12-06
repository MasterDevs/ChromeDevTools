using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Emulates the given media for CSS media queries.
	/// </summary>
	[Command(ProtocolName.Page.SetEmulatedMedia)]
	[SupportedBy("iOS")]
	public class SetEmulatedMediaCommand: ICommand<SetEmulatedMediaCommandResponse>
	{
		/// <summary>
		/// Gets or sets Media type to emulate. Empty string disables the override.
		/// </summary>
		public string Media { get; set; }
	}
}
