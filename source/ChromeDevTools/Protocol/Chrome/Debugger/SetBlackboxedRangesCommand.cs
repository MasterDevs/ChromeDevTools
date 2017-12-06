using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Makes backend skip steps in the script in blackboxed ranges. VM will try leave blacklisted scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful. Positions array contains positions where blackbox state is changed. First interval isn't blackboxed. Array should be sorted.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBlackboxedRanges)]
	[SupportedBy("Chrome")]
	public class SetBlackboxedRangesCommand: ICommand<SetBlackboxedRangesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the script.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Positions
		/// </summary>
		public ScriptPosition[] Positions { get; set; }
	}
}
