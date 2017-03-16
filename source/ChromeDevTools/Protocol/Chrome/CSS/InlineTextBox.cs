using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Details of post layout rendered text positions. The exact layout should not be regarded as stable and may change between versions.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InlineTextBox
	{
		/// <summary>
		/// Gets or sets The absolute position bounding box.
		/// </summary>
		public DOM.Rect BoundingBox { get; set; }
		/// <summary>
		/// Gets or sets The starting index in characters, for this post layout textbox substring.
		/// </summary>
		public long StartCharacterIndex { get; set; }
		/// <summary>
		/// Gets or sets The number of characters in this post layout textbox substring.
		/// </summary>
		public long NumCharacters { get; set; }
	}
}
