using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>
	[Command(ProtocolName.Page.SetDocumentContent)]
	public class SetDocumentContentCommand
	{
		/// <summary>
		/// Gets or sets Frame id to set HTML for.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets HTML content to set.
		/// </summary>
		public string Html { get; set; }
	}
}
