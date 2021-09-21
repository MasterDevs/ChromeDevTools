using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Get Origin Trials on given frame.
	/// </summary>
	[Command(ProtocolName.Page.GetOriginTrials)]
	[SupportedBy("Chrome")]
	public class GetOriginTrialsCommand: ICommand<GetOriginTrialsCommandResponse>
	{
		/// <summary>
		/// Gets or sets FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
