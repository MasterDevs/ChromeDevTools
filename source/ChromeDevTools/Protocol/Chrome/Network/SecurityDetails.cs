using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Security details about a request.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SecurityDetails
	{
		/// <summary>
		/// Gets or sets Protocol name (e.g. "TLS 1.2" or "QUIC").
		/// </summary>
		public string Protocol { get; set; }
		/// <summary>
		/// Gets or sets Key Exchange used by the connection, or the empty string if not applicable.
		/// </summary>
		public string KeyExchange { get; set; }
		/// <summary>
		/// Gets or sets (EC)DH group used by the connection, if applicable.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string KeyExchangeGroup { get; set; }
		/// <summary>
		/// Gets or sets Cipher name.
		/// </summary>
		public string Cipher { get; set; }
		/// <summary>
		/// Gets or sets TLS MAC. Note that AEAD ciphers do not have separate MACs.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Mac { get; set; }
		/// <summary>
		/// Gets or sets Certificate ID value.
		/// </summary>
		public long CertificateId { get; set; }
		/// <summary>
		/// Gets or sets Certificate subject name.
		/// </summary>
		public string SubjectName { get; set; }
		/// <summary>
		/// Gets or sets Subject Alternative Name (SAN) DNS names and IP addresses.
		/// </summary>
		public string[] SanList { get; set; }
		/// <summary>
		/// Gets or sets Name of the issuing CA.
		/// </summary>
		public string Issuer { get; set; }
		/// <summary>
		/// Gets or sets Certificate valid from date.
		/// </summary>
		public double ValidFrom { get; set; }
		/// <summary>
		/// Gets or sets Certificate valid to (expiration) date
		/// </summary>
		public double ValidTo { get; set; }
		/// <summary>
		/// Gets or sets List of signed certificate timestamps (SCTs).
		/// </summary>
		public SignedCertificateTimestamp[] SignedCertificateTimestampList { get; set; }
	}
}
