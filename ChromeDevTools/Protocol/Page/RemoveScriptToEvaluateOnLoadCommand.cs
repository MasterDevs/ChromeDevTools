using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	[Command(ProtocolName.Page.RemoveScriptToEvaluateOnLoad)]
	public class RemoveScriptToEvaluateOnLoadCommand
	{
		/// <summary>
		/// Gets or sets Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}
