using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// For the main document and any content documents, return the LayoutTreeNodes and a whitelisted subset of the computed style. It only returns pushed nodes, on way to pull all nodes is to call DOM.getDocument with a depth of -1.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetLayoutTreeAndStyles)]
	[SupportedBy("Chrome")]
	public class GetLayoutTreeAndStylesCommandResponse
	{
		/// <summary>
		/// Gets or sets LayoutTreeNodes
		/// </summary>
		public LayoutTreeNode[] LayoutTreeNodes { get; set; }
		/// <summary>
		/// Gets or sets ComputedStyles
		/// </summary>
		public ComputedStyle[] ComputedStyles { get; set; }
	}
}
