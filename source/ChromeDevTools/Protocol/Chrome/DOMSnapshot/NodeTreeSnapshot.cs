using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Table containing nodes.
	/// </summary>
	[SupportedBy("Chrome")]
	public class NodeTreeSnapshot
	{
		/// <summary>
		/// Gets or sets Parent node index.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] ParentIndex { get; set; }
		/// <summary>
		/// Gets or sets `Node`'s nodeType.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] NodeType { get; set; }
		/// <summary>
		/// Gets or sets Type of the shadow root the `Node` is in. String values are equal to the `ShadowRootType` enum.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData ShadowRootType { get; set; }
		/// <summary>
		/// Gets or sets `Node`'s nodeName.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] NodeName { get; set; }
		/// <summary>
		/// Gets or sets `Node`'s nodeValue.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] NodeValue { get; set; }
		/// <summary>
		/// Gets or sets `Node`'s id, corresponds to DOM.Node.backendNodeId.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets Attributes of an `Element` node. Flatten name, value pairs.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public int[] Attributes { get; set; }
		/// <summary>
		/// Gets or sets Only set for textarea elements, contains the text value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData TextValue { get; set; }
		/// <summary>
		/// Gets or sets Only set for input elements, contains the input's associated text value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData InputValue { get; set; }
		/// <summary>
		/// Gets or sets Only set for radio and checkbox input elements, indicates if the element has been checked
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareBooleanData InputChecked { get; set; }
		/// <summary>
		/// Gets or sets Only set for option elements, indicates if the element has been selected
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareBooleanData OptionSelected { get; set; }
		/// <summary>
		/// Gets or sets The index of the document in the list of the snapshot documents.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareIntegerData ContentDocumentIndex { get; set; }
		/// <summary>
		/// Gets or sets Type of a pseudo element node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData PseudoType { get; set; }
		/// <summary>
		/// Gets or sets Whether this DOM node responds to mouse clicks. This includes nodes that have had click
		/// event listeners attached via JavaScript as well as anchor tags that naturally navigate when
		/// clicked.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareBooleanData IsClickable { get; set; }
		/// <summary>
		/// Gets or sets The selected url for nodes with a srcset attribute.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData CurrentSourceURL { get; set; }
		/// <summary>
		/// Gets or sets The url of the script (if any) that generates this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RareStringData OriginURL { get; set; }
	}
}
