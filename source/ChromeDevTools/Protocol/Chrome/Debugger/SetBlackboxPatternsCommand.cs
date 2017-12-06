using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Replace previous blackbox patterns with passed ones. Forces backend to skip stepping/pausing in scripts with url matching one of the patterns. VM will try to leave blackboxed script by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBlackboxPatterns)]
	[SupportedBy("Chrome")]
	public class SetBlackboxPatternsCommand: ICommand<SetBlackboxPatternsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Array of regexps that will be used to check script url for blackbox state.
		/// </summary>
		public string[] Patterns { get; set; }
	}
}
