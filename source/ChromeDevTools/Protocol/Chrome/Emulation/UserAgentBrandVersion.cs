using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Used to specify User Agent Cient Hints to emulate. See https://wicg.github.io/ua-client-hints
	/// </summary>
	[SupportedBy("Chrome")]
	public class UserAgentBrandVersion
	{
		/// <summary>
		/// Gets or sets Brand
		/// </summary>
		public string Brand { get; set; }
		/// <summary>
		/// Gets or sets Version
		/// </summary>
		public string Version { get; set; }
	}
}
