using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	[Command(ProtocolName.Target.SetAttachToFrames)]
	[SupportedBy("Chrome")]
	public class SetAttachToFramesCommand: ICommand<SetAttachToFramesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to attach to frames.
		/// </summary>
		public bool Value { get; set; }
	}
}
