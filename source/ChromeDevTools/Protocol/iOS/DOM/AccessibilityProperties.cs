using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// A structure holding accessibility properties.
	/// </summary>
	[SupportedBy("iOS")]
	public class AccessibilityProperties
	{
		/// <summary>
		/// Gets or sets <code>DOMNode</code> id of the accessibility object referenced by aria-activedescendant.
		/// </summary>
		public long ActiveDescendantNodeId { get; set; }
		/// <summary>
		/// Gets or sets Value of @aria-busy on current or ancestor node.
		/// </summary>
		public bool Busy { get; set; }
		/// <summary>
		/// Gets or sets Checked state of certain form controls.
		/// </summary>
		public string Checked { get; set; }
		/// <summary>
		/// Gets or sets Array of <code>DOMNode</code> ids of the accessibility tree children if available.
		/// </summary>
		public long[] ChildNodeIds { get; set; }
		/// <summary>
		/// Gets or sets Array of <code>DOMNode</code> ids of any nodes referenced via @aria-controls.
		/// </summary>
		public long[] ControlledNodeIds { get; set; }
		/// <summary>
		/// Gets or sets Disabled state of form controls.
		/// </summary>
		public bool Disabled { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether there is an existing AX object for the DOM node. If this is false, all the other properties will be default values.
		/// </summary>
		public bool Exists { get; set; }
		/// <summary>
		/// Gets or sets Expanded state.
		/// </summary>
		public bool Expanded { get; set; }
		/// <summary>
		/// Gets or sets Array of <code>DOMNode</code> ids of any nodes referenced via @aria-flowto.
		/// </summary>
		public long[] FlowedNodeIds { get; set; }
		/// <summary>
		/// Gets or sets Focused state. Only defined on focusable elements.
		/// </summary>
		public bool Focused { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether the accessibility of the associated AX object node is ignored, whether heuristically or explicitly.
		/// </summary>
		public bool Ignored { get; set; }
		/// <summary>
		/// Gets or sets State indicating whether the accessibility of the associated AX object node is ignored by default for node type.
		/// </summary>
		public bool IgnoredByDefault { get; set; }
		/// <summary>
		/// Gets or sets Invalid status of form controls.
		/// </summary>
		public string Invalid { get; set; }
		/// <summary>
		/// Gets or sets Hidden state. True if node or an ancestor is hidden via CSS or explicit @aria-hidden, to clarify why the element is ignored.
		/// </summary>
		public bool Hidden { get; set; }
		/// <summary>
		/// Gets or sets Computed label value for the node, sometimes calculated by referencing other nodes.
		/// </summary>
		public string Label { get; set; }
		/// <summary>
		/// Gets or sets Value of @aria-atomic.
		/// </summary>
		public bool LiveRegionAtomic { get; set; }
		/// <summary>
		/// Gets or sets Token value(s) of element's @aria-relevant attribute. Array of string values matching $ref LiveRegionRelevant. FIXME: Enum values blocked by http://webkit.org/b/133711
		/// </summary>
		public string[] LiveRegionRelevant { get; set; }
		/// <summary>
		/// Gets or sets Value of element's @aria-live attribute.
		/// </summary>
		public string LiveRegionStatus { get; set; }
		/// <summary>
		/// Gets or sets <code>DOMNode</code> id of node or closest ancestor node that has a mousedown, mouseup, or click event handler.
		/// </summary>
		public long MouseEventNodeId { get; set; }
		/// <summary>
		/// Gets or sets Target <code>DOMNode</code> id.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Array of <code>DOMNode</code> ids of any nodes referenced via @aria-owns.
		/// </summary>
		public long[] OwnedNodeIds { get; set; }
		/// <summary>
		/// Gets or sets <code>DOMNode</code> id of the accessibility tree parent object if available.
		/// </summary>
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Pressed state for toggle buttons.
		/// </summary>
		public bool Pressed { get; set; }
		/// <summary>
		/// Gets or sets Readonly state of text controls.
		/// </summary>
		public bool Readonly { get; set; }
		/// <summary>
		/// Gets or sets Required state of form controls.
		/// </summary>
		public bool Required { get; set; }
		/// <summary>
		/// Gets or sets Computed value for first recognized role token, default role per element, or overridden role.
		/// </summary>
		public string Role { get; set; }
		/// <summary>
		/// Gets or sets Selected state of certain form controls.
		/// </summary>
		public bool Selected { get; set; }
		/// <summary>
		/// Gets or sets Array of <code>DOMNode</code> ids of any children marked as selected.
		/// </summary>
		public long[] SelectedChildNodeIds { get; set; }
	}
}
