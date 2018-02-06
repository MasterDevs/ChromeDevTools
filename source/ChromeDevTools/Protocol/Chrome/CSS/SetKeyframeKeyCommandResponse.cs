using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the keyframe rule key text.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetKeyframeKey)]
	[SupportedBy("Chrome")]
	public class SetKeyframeKeyCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting key text after modification.
		/// </summary>
		public Value KeyText { get; set; }
	}
}
