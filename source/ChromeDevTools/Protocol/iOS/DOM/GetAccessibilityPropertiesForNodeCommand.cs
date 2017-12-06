using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns a dictionary of accessibility properties for the node.
	/// </summary>
	[Command(ProtocolName.DOM.GetAccessibilityPropertiesForNode)]
	[SupportedBy("iOS")]
	public class GetAccessibilityPropertiesForNodeCommand: ICommand<GetAccessibilityPropertiesForNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node for which to get accessibility properties.
		/// </summary>
		public long NodeId { get; set; }
	}
}
