using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides value returned by the javascript navigator object.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Emulation.SetNavigatorOverrides)]
	[SupportedBy("Chrome")]
	public class SetNavigatorOverridesCommand: ICommand<SetNavigatorOverridesCommandResponse>
	{
		/// <summary>
		/// Gets or sets The platform navigator.platform should return.
		/// </summary>
		public string Platform { get; set; }
	}
}
