using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets files for the given file input element.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetFileInputFiles)]
	[SupportedBy("Chrome")]
	public class SetFileInputFilesCommandResponse
	{
	}
}
