using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class CorsErrorStatus
	{
		/// <summary>
		/// Gets or sets CorsError
		/// </summary>
		public CorsError CorsError { get; set; }
		/// <summary>
		/// Gets or sets FailedParameter
		/// </summary>
		public string FailedParameter { get; set; }
	}
}
