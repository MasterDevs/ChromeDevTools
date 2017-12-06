using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Describes node given its id, does not require domain to be enabled. Does not start tracking any objects, can be used for automation.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.DescribeNode)]
	[SupportedBy("Chrome")]
	public class DescribeNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Node description.
		/// </summary>
		public Node Node { get; set; }
	}
}
