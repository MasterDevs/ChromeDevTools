using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Releases remote object with given id.
	/// </summary>
	[Command(ProtocolName.Runtime.ReleaseObject)]
	public class ReleaseObjectCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the object to release.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
