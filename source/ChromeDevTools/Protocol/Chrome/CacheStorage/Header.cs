using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	[SupportedBy("Chrome")]
	public class Header
	{
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public string Value { get; set; }
	}
}
