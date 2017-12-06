using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Enable/disable overriding certificate errors. If enabled, all certificate error events need to be handled by the DevTools client and should be answered with handleCertificateError commands.
	/// </summary>
	[CommandResponse(ProtocolName.Security.SetOverrideCertificateErrors)]
	[SupportedBy("Chrome")]
	public class SetOverrideCertificateErrorsCommandResponse
	{
	}
}
