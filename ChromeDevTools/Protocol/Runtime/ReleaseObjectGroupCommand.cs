using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Releases all remote objects that belong to a given group.
	/// </summary>
	[Command(ProtocolName.Runtime.ReleaseObjectGroup)]
	public class ReleaseObjectGroupCommand
	{
		/// <summary>
		/// Gets or sets Symbolic object group name.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
