using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>
	[Command(ProtocolName.DOM.GetOuterHTML)]
	[SupportedBy("iOS")]
	public class GetOuterHTMLCommand: ICommand<GetOuterHTMLCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to get markup for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
