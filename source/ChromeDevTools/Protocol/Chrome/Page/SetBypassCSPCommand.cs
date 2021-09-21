using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Enable page Content Security Policy by-passing.
	/// </summary>
	[Command(ProtocolName.Page.SetBypassCSP)]
	[SupportedBy("Chrome")]
	public class SetBypassCSPCommand: ICommand<SetBypassCSPCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to bypass page CSP.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
