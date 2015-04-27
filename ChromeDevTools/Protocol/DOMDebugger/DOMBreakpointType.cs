using ChromeDevTools;

namespace ChromeDevTools.Protocol.DOMDebugger{
	/// <summary>
	/// DOM breakpoint type.
	/// </summary>
	public enum DOMBreakpointType
	{
			Subtree_modified,
			Attribute_modified,
			Node_removed,
	}
}
