using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Either replaces a property identified by <code>styleSheetId</code> and <code>range</code> with <code>text</code> or inserts a new property <code>text</code> at the position identified by an empty <code>range</code>.
	/// </summary>
	[Command(ProtocolName.CSS.SetPropertyText)]
	public class SetPropertyTextCommand
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Either a source range of the property to be edited or an empty range representing a position for the property insertion.
		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets Text
		/// </summary>
		public string Text { get; set; }
	}
}
