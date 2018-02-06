using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns the DER-encoded certificate.
	/// </summary>
	[CommandResponse(ProtocolName.Network.GetCertificate)]
	[SupportedBy("Chrome")]
	public class GetCertificateCommandResponse
	{
		/// <summary>
		/// Gets or sets TableNames
		/// </summary>
		public string[] TableNames { get; set; }
	}
}
