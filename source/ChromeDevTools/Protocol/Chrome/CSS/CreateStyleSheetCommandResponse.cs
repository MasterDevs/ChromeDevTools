using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Creates a new special "via-inspector" stylesheet in the frame with given <code>frameId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.CreateStyleSheet)]
	[SupportedBy("Chrome")]
	public class CreateStyleSheetCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the created "via-inspector" stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
