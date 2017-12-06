using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// For testing.
	/// </summary>
	[Command(ProtocolName.Overlay.GetHighlightObjectForTest)]
	[SupportedBy("Chrome")]
	public class GetHighlightObjectForTestCommand: ICommand<GetHighlightObjectForTestCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to get highlight object for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
