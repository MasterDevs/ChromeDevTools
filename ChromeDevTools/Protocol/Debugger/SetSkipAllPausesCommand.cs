using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
	/// </summary>
	[Command(ProtocolName.Debugger.SetSkipAllPauses)]
	public class SetSkipAllPausesCommand
	{
		/// <summary>
		/// Gets or sets New value for skip pauses state.
		/// </summary>
		public bool Skipped { get; set; }
	}
}
