using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns metainfo entries for all known stylesheets.
	/// </summary>
	[Command(ProtocolName.CSS.GetAllStyleSheets)]
	[SupportedBy("iOS")]
	public class GetAllStyleSheetsCommand: ICommand<GetAllStyleSheetsCommandResponse>
	{
	}
}
