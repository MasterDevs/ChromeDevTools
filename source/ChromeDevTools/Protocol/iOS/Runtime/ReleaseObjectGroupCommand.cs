using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Releases all remote objects that belong to a given group.
	/// </summary>
	[Command(ProtocolName.Runtime.ReleaseObjectGroup)]
	[SupportedBy("iOS")]
	public class ReleaseObjectGroupCommand: ICommand<ReleaseObjectGroupCommandResponse>
	{
		/// <summary>
		/// Gets or sets Symbolic object group name.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
