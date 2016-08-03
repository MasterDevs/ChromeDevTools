using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// CSS stylesheet metainformation.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSStyleSheetHeader
	{
		/// <summary>
		/// Gets or sets The stylesheet identifier.
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Owner frame identifier.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet resource URL.
		/// </summary>
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet origin.
		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet title.
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Gets or sets Denotes whether the stylesheet is disabled.
		/// </summary>
		public bool Disabled { get; set; }
		/// <summary>
		/// Gets or sets Whether this stylesheet is a <style> tag created by the parser. This is not set for document.written <style> tags.
		/// </summary>
		public bool IsInline { get; set; }
		/// <summary>
		/// Gets or sets Line offset of the stylesheet within the resource (zero based).
		/// </summary>
		public double StartLine { get; set; }
		/// <summary>
		/// Gets or sets Column offset of the stylesheet within the resource (zero based).
		/// </summary>
		public double StartColumn { get; set; }
	}
}
