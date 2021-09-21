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
	[Command(ProtocolName.Browser.GetBrowserCommandLine)]
	[SupportedBy("Chrome")]
	public class GetBrowserCommandLineCommand: ICommand<GetBrowserCommandLineCommandResponse>
	{
	}
}
