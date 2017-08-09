using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns the DER-encoded certificate.
	/// </summary>
	[Command(ProtocolName.Network.GetCertificate)]
	[SupportedBy("Chrome")]
	public class GetCertificateCommand
	{
		/// <summary>
		/// Gets or sets Origin to get certificate for.
		/// </summary>
		public string Origin { get; set; }
	}
}
