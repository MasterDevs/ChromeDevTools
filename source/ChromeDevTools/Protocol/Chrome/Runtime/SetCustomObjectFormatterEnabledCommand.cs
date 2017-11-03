using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[Command(ProtocolName.Runtime.SetCustomObjectFormatterEnabled)]
	[SupportedBy("Chrome")]
	public class SetCustomObjectFormatterEnabledCommand: ICommand<SetCustomObjectFormatterEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Enabled
		/// </summary>
		public bool Enabled { get; set; }
	}
}
