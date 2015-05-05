using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets files for the given file input element.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetFileInputFiles)]
	public class SetFileInputFilesCommandResponse
	{
	}
}
