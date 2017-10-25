using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>
	[Command(ProtocolName.DOM.GetOuterHTML)]
	[SupportedBy("Chrome")]
	public class GetOuterHTMLCommand: ICommand<GetOuterHTMLCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to get markup for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
