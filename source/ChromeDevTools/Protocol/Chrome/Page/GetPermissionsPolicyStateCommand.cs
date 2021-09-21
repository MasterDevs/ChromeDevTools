using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Get Permissions Policy state on given frame.
	/// </summary>
	[Command(ProtocolName.Page.GetPermissionsPolicyState)]
	[SupportedBy("Chrome")]
	public class GetPermissionsPolicyStateCommand: ICommand<GetPermissionsPolicyStateCommandResponse>
	{
		/// <summary>
		/// Gets or sets FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
