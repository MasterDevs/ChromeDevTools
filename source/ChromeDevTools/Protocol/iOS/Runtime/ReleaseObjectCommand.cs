using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Releases remote object with given id.
	/// </summary>
	[Command(ProtocolName.Runtime.ReleaseObject)]
	[SupportedBy("iOS")]
	public class ReleaseObjectCommand: ICommand<ReleaseObjectCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the object to release.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
