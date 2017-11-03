using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Resolves JavaScript node object for given node id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.ResolveNode)]
	[SupportedBy("iOS")]
	public class ResolveNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets JavaScript object wrapper for given node.
		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
	}
}
