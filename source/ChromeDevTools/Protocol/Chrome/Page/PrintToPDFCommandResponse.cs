using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Print page as PDF.
	/// </summary>
	[CommandResponse(ProtocolName.Page.PrintToPDF)]
	[SupportedBy("Chrome")]
	public class PrintToPDFCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded pdf data.
		/// </summary>
		public string Data { get; set; }
	}
}
