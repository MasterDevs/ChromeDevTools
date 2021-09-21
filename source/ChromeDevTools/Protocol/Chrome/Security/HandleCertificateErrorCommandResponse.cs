using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Handles a certificate error that fired a certificateError event.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Security.HandleCertificateError)]
	[SupportedBy("Chrome")]
	public class HandleCertificateErrorCommandResponse
	{
	}
}
