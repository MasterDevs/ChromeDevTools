using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// The reason why request was blocked.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BlockedReason
	{
			Other,
			Csp,
			[EnumMember(Value = "mixed-content")]
			Mixed_content,
			Origin,
			Inspector,
			[EnumMember(Value = "subresource-filter")]
			Subresource_filter,
			[EnumMember(Value = "content-type")]
			Content_type,
			[EnumMember(Value = "coep-frame-resource-needs-coep-header")]
			Coep_frame_resource_needs_coep_header,
			[EnumMember(Value = "coop-sandboxed-iframe-cannot-navigate-to-coop-page")]
			Coop_sandboxed_iframe_cannot_navigate_to_coop_page,
			[EnumMember(Value = "corp-not-same-origin")]
			Corp_not_same_origin,
			[EnumMember(Value = "corp-not-same-origin-after-defaulted-to-same-origin-by-coep")]
			Corp_not_same_origin_after_defaulted_to_same_origin_by_coep,
			[EnumMember(Value = "corp-not-same-site")]
			Corp_not_same_site,
	}
}
