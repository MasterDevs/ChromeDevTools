using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns all let, const and class variables from global scope.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GlobalLexicalScopeNames)]
	[SupportedBy("Chrome")]
	public class GlobalLexicalScopeNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Names
		/// </summary>
		public string[] Names { get; set; }
	}
}
