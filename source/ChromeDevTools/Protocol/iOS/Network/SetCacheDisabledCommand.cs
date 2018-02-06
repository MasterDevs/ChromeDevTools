using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Toggles ignoring cache for each request. If <code>true</code>, cache will not be used.
	/// </summary>
	[Command(ProtocolName.Network.SetCacheDisabled)]
	[SupportedBy("iOS")]
	public class SetCacheDisabledCommand: ICommand<SetCacheDisabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Cache disabled state.
		/// </summary>
		public bool CacheDisabled { get; set; }
	}
}
