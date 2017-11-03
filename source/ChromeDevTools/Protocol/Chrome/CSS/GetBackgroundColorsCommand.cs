using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	[Command(ProtocolName.CSS.GetBackgroundColors)]
	[SupportedBy("Chrome")]
	public class GetBackgroundColorsCommand: ICommand<GetBackgroundColorsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to get background colors for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
