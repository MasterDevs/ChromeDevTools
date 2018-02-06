using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Edits JavaScript source live.
	/// </summary>
	[Command(ProtocolName.Debugger.SetScriptSource)]
	[SupportedBy("Chrome")]
	public class SetScriptSourceCommand: ICommand<SetScriptSourceCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the script to edit.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets New content of the script.
		/// </summary>
		public string ScriptSource { get; set; }
		/// <summary>
		/// Gets or sets  If true the change will not actually be applied. Dry run may be used to get result description without actually modifying the code.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DryRun { get; set; }
	}
}
