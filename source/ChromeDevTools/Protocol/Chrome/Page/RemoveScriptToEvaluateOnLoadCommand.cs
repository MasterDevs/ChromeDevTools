using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[Command(ProtocolName.Page.RemoveScriptToEvaluateOnLoad)]
	[SupportedBy("Chrome")]
	public class RemoveScriptToEvaluateOnLoadCommand: ICommand<RemoveScriptToEvaluateOnLoadCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}
