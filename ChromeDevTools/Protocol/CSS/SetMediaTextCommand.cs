using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[Command(ProtocolName.CSS.SetMediaText)]
	public class SetMediaTextCommand
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Range
		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets Text
		/// </summary>
		public string Text { get; set; }
	}
}
