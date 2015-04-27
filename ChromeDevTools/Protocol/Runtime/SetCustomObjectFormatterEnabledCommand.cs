using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	[Command(ProtocolName.Runtime.SetCustomObjectFormatterEnabled)]
	public class SetCustomObjectFormatterEnabledCommand
	{
		/// <summary>
		/// Gets or sets Enabled
		/// </summary>
		public bool Enabled { get; set; }
	}
}
