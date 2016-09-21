using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger{
	/// <summary>
	/// DOM breakpoint type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DOMBreakpointType
	{
			[EnumMember(Value = "subtree-modified")]
			Subtree_modified,
			[EnumMember(Value = "attribute-modified")]
			Attribute_modified,
			[EnumMember(Value = "node-removed")]
			Node_removed,
	}
}
