using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Closes the target. If the target is a page that gets closed too.
	/// </summary>
	[Command(ProtocolName.Target.CloseTarget)]
	[SupportedBy("Chrome")]
	public class CloseTargetCommand: ICommand<CloseTargetCommandResponse>
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
