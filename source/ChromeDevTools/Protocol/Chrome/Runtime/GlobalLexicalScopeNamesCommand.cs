using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns all let, const and class variables from global scope.
	/// </summary>
	[Command(ProtocolName.Runtime.GlobalLexicalScopeNames)]
	[SupportedBy("Chrome")]
	public class GlobalLexicalScopeNamesCommand: ICommand<GlobalLexicalScopeNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Specifies in which execution context to lookup global scope variables.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ExecutionContextId { get; set; }
	}
}
