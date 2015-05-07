using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
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
