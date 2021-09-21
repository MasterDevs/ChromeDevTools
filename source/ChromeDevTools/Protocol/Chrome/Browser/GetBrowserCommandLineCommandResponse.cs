using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Returns the command line switches for the browser process if, and only if
	/// --enable-automation is on the commandline.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.GetBrowserCommandLine)]
	[SupportedBy("Chrome")]
	public class GetBrowserCommandLineCommandResponse
	{
		/// <summary>
		/// Gets or sets Commandline parameters
		/// </summary>
		public string[] Arguments { get; set; }
	}
}
