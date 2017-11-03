using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns a dictionary of accessibility properties for the node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetAccessibilityPropertiesForNode)]
	[SupportedBy("iOS")]
	public class GetAccessibilityPropertiesForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Dictionary of relevant accessibility properties.
		/// </summary>
		public AccessibilityProperties Properties { get; set; }
	}
}
