using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	[SupportedBy("Chrome")]
	public class VirtualAuthenticatorOptions
	{
		/// <summary>
		/// Gets or sets Protocol
		/// </summary>
		public AuthenticatorProtocol Protocol { get; set; }
		/// <summary>
		/// Gets or sets Defaults to ctap2_0. Ignored if |protocol| == u2f.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Ctap2Version Ctap2Version { get; set; }
		/// <summary>
		/// Gets or sets Transport
		/// </summary>
		public AuthenticatorTransport Transport { get; set; }
		/// <summary>
		/// Gets or sets Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasResidentKey { get; set; }
		/// <summary>
		/// Gets or sets Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasUserVerification { get; set; }
		/// <summary>
		/// Gets or sets If set to true, the authenticator will support the largeBlob extension.
		/// https://w3c.github.io/webauthn#largeBlob
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasLargeBlob { get; set; }
		/// <summary>
		/// Gets or sets If set to true, the authenticator will support the credBlob extension.
		/// https://fidoalliance.org/specs/fido-v2.1-rd-20201208/fido-client-to-authenticator-protocol-v2.1-rd-20201208.html#sctn-credBlob-extension
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasCredBlob { get; set; }
		/// <summary>
		/// Gets or sets If set to true, tests of user presence will succeed immediately.
		/// Otherwise, they will not be resolved. Defaults to true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AutomaticPresenceSimulation { get; set; }
		/// <summary>
		/// Gets or sets Sets whether User Verification succeeds or fails for an authenticator.
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsUserVerified { get; set; }
	}
}
