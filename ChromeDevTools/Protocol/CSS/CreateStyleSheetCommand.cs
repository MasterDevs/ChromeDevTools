using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Creates a new special "via-inspector" stylesheet in the frame with given <code>frameId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.CreateStyleSheet)]
	public class CreateStyleSheetCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame where "via-inspector" stylesheet should be created.
		/// </summary>
		public string FrameId { get; set; }
	}
}
