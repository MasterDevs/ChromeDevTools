using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Parses JavaScript source code for errors.
	/// </summary>
	[Command(ProtocolName.Runtime.Parse)]
	[SupportedBy("iOS")]
	public class ParseCommand: ICommand<ParseCommandResponse>
	{
		/// <summary>
		/// Gets or sets Source code to parse.
		/// </summary>
		public string Source { get; set; }
	}
}
