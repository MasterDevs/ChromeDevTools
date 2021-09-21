using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Add a dual screen device hinge
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowHinge)]
	[SupportedBy("Chrome")]
	public class SetShowHingeCommand: ICommand<SetShowHingeCommandResponse>
	{
		/// <summary>
		/// Gets or sets hinge data, null means hideHinge
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HingeConfig HingeConfig { get; set; }
	}
}
