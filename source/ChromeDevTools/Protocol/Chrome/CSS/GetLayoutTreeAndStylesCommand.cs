using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// For the main document and any content documents, return the LayoutTreeNodes and a whitelisted subset of the computed style. It only returns pushed nodes, on way to pull all nodes is to call DOM.getDocument with a depth of -1.
	/// </summary>
	[Command(ProtocolName.CSS.GetLayoutTreeAndStyles)]
	[SupportedBy("Chrome")]
	public class GetLayoutTreeAndStylesCommand
	{
		/// <summary>
		/// Gets or sets Whitelist of computed styles to return.
		/// </summary>
		public string[] ComputedStyleWhitelist { get; set; }
	}
}
