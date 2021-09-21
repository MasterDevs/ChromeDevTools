using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Controls whether page will emit lifecycle events.
	/// </summary>
	[Command(ProtocolName.Page.SetLifecycleEventsEnabled)]
	[SupportedBy("Chrome")]
	public class SetLifecycleEventsEnabledCommand: ICommand<SetLifecycleEventsEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets If true, starts emitting lifecycle events.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
