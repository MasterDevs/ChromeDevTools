using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Detaches from the target with given id.
	/// </summary>
	[Command(ProtocolName.Target.DetachFromTarget)]
	[SupportedBy("Chrome")]
	public class DetachFromTargetCommand: ICommand<DetachFromTargetCommandResponse>
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
