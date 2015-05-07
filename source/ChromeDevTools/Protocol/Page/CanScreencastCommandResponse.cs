using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Tells whether screencast is supported.
	/// </summary>
	[CommandResponse(ProtocolName.Page.CanScreencast)]
	public class CanScreencastCommandResponse
	{
		/// <summary>
		/// Gets or sets True if screencast is supported.
		/// </summary>
		public bool Result { get; set; }
	}
}
