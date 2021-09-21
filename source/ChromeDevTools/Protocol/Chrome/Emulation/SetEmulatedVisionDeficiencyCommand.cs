using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Emulates the given vision deficiency.
	/// </summary>
	[Command(ProtocolName.Emulation.SetEmulatedVisionDeficiency)]
	[SupportedBy("Chrome")]
	public class SetEmulatedVisionDeficiencyCommand: ICommand<SetEmulatedVisionDeficiencyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Vision deficiency to emulate.
		/// </summary>
		public string Type { get; set; }
	}
}
