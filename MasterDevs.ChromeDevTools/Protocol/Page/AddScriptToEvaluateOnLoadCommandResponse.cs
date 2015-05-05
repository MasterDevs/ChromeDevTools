using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	[CommandResponse(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	public class AddScriptToEvaluateOnLoadCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the added script.
		/// </summary>
		public string Identifier { get; set; }
	}
}
