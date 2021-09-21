using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	[SupportedBy("Chrome")]
	public class Credential
	{
		/// <summary>
		/// Gets or sets CredentialId
		/// </summary>
		public string CredentialId { get; set; }
		/// <summary>
		/// Gets or sets IsResidentCredential
		/// </summary>
		public bool IsResidentCredential { get; set; }
		/// <summary>
		/// Gets or sets Relying Party ID the credential is scoped to. Must be set when adding acredential.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RpId { get; set; }
		/// <summary>
		/// Gets or sets The ECDSA P-256 private key in PKCS#8 format. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string PrivateKey { get; set; }
		/// <summary>
		/// Gets or sets An opaque byte sequence with a maximum size of 64 bytes mapping the credential to a specific user. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UserHandle { get; set; }
		/// <summary>
		/// Gets or sets Signature counter. This is incremented by one for each successful assertion.
		/// See https://w3c.github.io/webauthn/#signature-counter
		/// </summary>
		public long SignCount { get; set; }
		/// <summary>
		/// Gets or sets The large blob associated with the credential.
		/// See https://w3c.github.io/webauthn/#sctn-large-blob-extension (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string LargeBlob { get; set; }
	}
}
