using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tethering
{
	/// <summary>
	/// Request browser port binding.
	/// </summary>
	[Command(ProtocolName.Tethering.Bind)]
	[SupportedBy("Chrome")]
	public class BindCommand
	{
		/// <summary>
		/// Gets or sets Port number to bind.
		/// </summary>
		public long Port { get; set; }
	}
}
