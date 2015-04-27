using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Edits JavaScript source live.
	/// </summary>
	[Command(ProtocolName.Debugger.SetScriptSource)]
	public class SetScriptSourceCommand
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
		/// Gets or sets  If true the change will not actually be applied. Preview mode may be used to get result description without actually modifying the code.
		/// </summary>
		public bool Preview { get; set; }
	}
}
