using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Resolves JavaScript node object for given node id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.ResolveNode)]
	public class ResolveNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets JavaScript object wrapper for given node.
		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
	}
}
