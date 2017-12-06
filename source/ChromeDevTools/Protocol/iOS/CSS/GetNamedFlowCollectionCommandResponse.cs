using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns the Named Flows from the document.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetNamedFlowCollection)]
	[SupportedBy("iOS")]
	public class GetNamedFlowCollectionCommandResponse
	{
		/// <summary>
		/// Gets or sets An array containing the Named Flows in the document.
		/// </summary>
		public NamedFlow[] NamedFlows { get; set; }
	}
}
