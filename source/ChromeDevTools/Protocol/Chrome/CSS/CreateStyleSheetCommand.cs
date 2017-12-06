using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Creates a new special "via-inspector" stylesheet in the frame with given <code>frameId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.CreateStyleSheet)]
	[SupportedBy("Chrome")]
	public class CreateStyleSheetCommand: ICommand<CreateStyleSheetCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the frame where "via-inspector" stylesheet should be created.
		/// </summary>
		public string FrameId { get; set; }
	}
}
