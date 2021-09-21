using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Location range within one script.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LocationRange
	{
		/// <summary>
		/// Gets or sets ScriptId
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Start
		/// </summary>
		public ScriptPosition Start { get; set; }
		/// <summary>
		/// Gets or sets End
		/// </summary>
		public ScriptPosition End { get; set; }
	}
}
