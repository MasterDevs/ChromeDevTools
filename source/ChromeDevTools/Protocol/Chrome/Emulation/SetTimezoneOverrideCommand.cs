using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides default host system timezone with the specified one.
	/// </summary>
	[Command(ProtocolName.Emulation.SetTimezoneOverride)]
	[SupportedBy("Chrome")]
	public class SetTimezoneOverrideCommand: ICommand<SetTimezoneOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets The timezone identifier. If empty, disables the override and
		/// restores default host system timezone.
		/// </summary>
		public string TimezoneId { get; set; }
	}
}
