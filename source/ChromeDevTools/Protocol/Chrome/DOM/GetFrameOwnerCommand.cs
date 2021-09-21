using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns iframe node that owns iframe with the given domain.
	/// </summary>
	[Command(ProtocolName.DOM.GetFrameOwner)]
	[SupportedBy("Chrome")]
	public class GetFrameOwnerCommand: ICommand<GetFrameOwnerCommandResponse>
	{
		/// <summary>
		/// Gets or sets FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
