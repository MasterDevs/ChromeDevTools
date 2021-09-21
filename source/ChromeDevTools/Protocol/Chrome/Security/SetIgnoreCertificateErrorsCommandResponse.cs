using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Enable/disable whether all certificate errors should be ignored.
	/// </summary>
	[CommandResponse(ProtocolName.Security.SetIgnoreCertificateErrors)]
	[SupportedBy("Chrome")]
	public class SetIgnoreCertificateErrorsCommandResponse
	{
	}
}
