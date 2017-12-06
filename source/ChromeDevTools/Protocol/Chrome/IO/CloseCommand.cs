using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IO
{
	/// <summary>
	/// Close the stream, discard any temporary backing storage.
	/// </summary>
	[Command(ProtocolName.IO.Close)]
	[SupportedBy("Chrome")]
	public class CloseCommand: ICommand<CloseCommandResponse>
	{
		/// <summary>
		/// Gets or sets Handle of the stream to close.
		/// </summary>
		public string Handle { get; set; }
	}
}
