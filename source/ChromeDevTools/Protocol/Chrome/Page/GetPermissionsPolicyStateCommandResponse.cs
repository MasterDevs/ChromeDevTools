using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Get Permissions Policy state on given frame.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetPermissionsPolicyState)]
	[SupportedBy("Chrome")]
	public class GetPermissionsPolicyStateCommandResponse
	{
		/// <summary>
		/// Gets or sets States
		/// </summary>
		public PermissionsPolicyFeatureState[] States { get; set; }
	}
}
