using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>
	[Command(ProtocolName.DOM.Focus)]
	[SupportedBy("Chrome")]
	public class FocusCommand: ICommand<FocusCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to focus.
		/// </summary>
		public long NodeId { get; set; }
	}
}
