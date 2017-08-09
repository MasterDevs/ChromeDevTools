using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Print page as pdf.
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
