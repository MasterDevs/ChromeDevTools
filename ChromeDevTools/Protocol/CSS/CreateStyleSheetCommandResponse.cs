using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Creates a new special "via-inspector" stylesheet in the frame with given <code>frameId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.CreateStyleSheet)]
	public class CreateStyleSheetCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the created "via-inspector" stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
