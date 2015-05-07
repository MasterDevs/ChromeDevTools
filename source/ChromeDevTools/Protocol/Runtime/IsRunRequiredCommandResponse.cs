using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	[CommandResponse(ProtocolName.Runtime.IsRunRequired)]
	public class IsRunRequiredCommandResponse
	{
		/// <summary>
		/// Gets or sets True if the Runtime is in paused on start state.
		/// </summary>
		public bool Result { get; set; }
	}
}
