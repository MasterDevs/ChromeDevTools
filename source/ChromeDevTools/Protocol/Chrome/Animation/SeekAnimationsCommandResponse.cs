using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Seek a set of animations to a particular time within each animation.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.SeekAnimations)]
	[SupportedBy("Chrome")]
	public class SeekAnimationsCommandResponse
	{
	}
}
