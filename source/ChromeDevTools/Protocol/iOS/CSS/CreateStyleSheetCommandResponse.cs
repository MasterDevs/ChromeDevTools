using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Creates a new special "inspector" stylesheet in the frame with given <code>frameId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.CreateStyleSheet)]
	[SupportedBy("iOS")]
	public class CreateStyleSheetCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the created "inspector" stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
