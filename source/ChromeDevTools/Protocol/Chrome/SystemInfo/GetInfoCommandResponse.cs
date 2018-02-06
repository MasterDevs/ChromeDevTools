using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about the system.
	/// </summary>
	[CommandResponse(ProtocolName.SystemInfo.GetInfo)]
	[SupportedBy("Chrome")]
	public class GetInfoCommandResponse
	{
		/// <summary>
		/// Gets or sets Information about the GPUs on the system.
		/// </summary>
		public GPUInfo Gpu { get; set; }
		/// <summary>
		/// Gets or sets A platform-dependent description of the model of the machine. On Mac OS, this is, for example, 'MacBookPro'. Will be the empty string if not supported.
		/// </summary>
		public string ModelName { get; set; }
		/// <summary>
		/// Gets or sets A platform-dependent description of the version of the machine. On Mac OS, this is, for example, '10.1'. Will be the empty string if not supported.
		/// </summary>
		public string ModelVersion { get; set; }
		/// <summary>
		/// Gets or sets The command line string used to launch the browser. Will be the empty string if not supported.
		/// </summary>
		public string CommandLine { get; set; }
	}
}
