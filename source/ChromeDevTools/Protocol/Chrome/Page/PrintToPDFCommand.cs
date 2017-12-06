using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Print page as PDF.
	/// </summary>
	[Command(ProtocolName.Page.PrintToPDF)]
	[SupportedBy("Chrome")]
	public class PrintToPDFCommand: ICommand<PrintToPDFCommandResponse>
	{
		/// <summary>
		/// Gets or sets Paper orientation. Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Landscape { get; set; }
		/// <summary>
		/// Gets or sets Display header and footer. Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DisplayHeaderFooter { get; set; }
		/// <summary>
		/// Gets or sets Print background graphics. Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? PrintBackground { get; set; }
		/// <summary>
		/// Gets or sets Scale of the webpage rendering. Defaults to 1.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Scale { get; set; }
		/// <summary>
		/// Gets or sets Paper width in inches. Defaults to 8.5 inches.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double PaperWidth { get; set; }
		/// <summary>
		/// Gets or sets Paper height in inches. Defaults to 11 inches.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double PaperHeight { get; set; }
		/// <summary>
		/// Gets or sets Top margin in inches. Defaults to 1cm (~0.4 inches).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MarginTop { get; set; }
		/// <summary>
		/// Gets or sets Bottom margin in inches. Defaults to 1cm (~0.4 inches).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MarginBottom { get; set; }
		/// <summary>
		/// Gets or sets Left margin in inches. Defaults to 1cm (~0.4 inches).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MarginLeft { get; set; }
		/// <summary>
		/// Gets or sets Right margin in inches. Defaults to 1cm (~0.4 inches).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MarginRight { get; set; }
		/// <summary>
		/// Gets or sets Paper ranges to print, e.g., '1-5, 8, 11-13'. Defaults to the empty string, which means print all pages.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PageRanges { get; set; }
		/// <summary>
		/// Gets or sets Whether to silently ignore invalid but successfully parsed page ranges, such as '3-2'. Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IgnoreInvalidPageRanges { get; set; }
	}
}
