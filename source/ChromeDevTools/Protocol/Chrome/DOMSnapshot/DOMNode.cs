using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// A Node in the DOM tree.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DOMNode
	{
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeType.
		/// </summary>
		public long NodeType { get; set; }
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeName.
		/// </summary>
		public string NodeName { get; set; }
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeValue.
		/// </summary>
		public string NodeValue { get; set; }
		/// <summary>
		/// Gets or sets Only set for textarea elements, contains the text value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TextValue { get; set; }
		/// <summary>
		/// Gets or sets Only set for input elements, contains the input's associated text value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InputValue { get; set; }
		/// <summary>
		/// Gets or sets Only set for radio and checkbox input elements, indicates if the element has been checked
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? InputChecked { get; set; }
		/// <summary>
		/// Gets or sets Only set for option elements, indicates if the element has been selected
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? OptionSelected { get; set; }
		/// <summary>
		/// Gets or sets <code>Node</code>'s id, corresponds to DOM.Node.backendNodeId.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets The indexes of the node's child nodes in the <code>domNodes</code> array returned by <code>getSnapshot</code>, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] ChildNodeIndexes { get; set; }
		/// <summary>
		/// Gets or sets Attributes of an <code>Element</code> node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NameValue[] Attributes { get; set; }
		/// <summary>
		/// Gets or sets Indexes of pseudo elements associated with this node in the <code>domNodes</code> array returned by <code>getSnapshot</code>, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] PseudoElementIndexes { get; set; }
		/// <summary>
		/// Gets or sets The index of the node's related layout tree node in the <code>layoutTreeNodes</code> array returned by <code>getSnapshot</code>, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? LayoutNodeIndex { get; set; }
		/// <summary>
		/// Gets or sets Document URL that <code>Document</code> or <code>FrameOwner</code> node points to.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or sets Base URL that <code>Document</code> or <code>FrameOwner</code> node uses for URL completion.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BaseURL { get; set; }
		/// <summary>
		/// Gets or sets Only set for documents, contains the document's content language.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ContentLanguage { get; set; }
		/// <summary>
		/// Gets or sets Only set for documents, contains the document's character set encoding.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DocumentEncoding { get; set; }
		/// <summary>
		/// Gets or sets <code>DocumentType</code> node's publicId.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PublicId { get; set; }
		/// <summary>
		/// Gets or sets <code>DocumentType</code> node's systemId.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SystemId { get; set; }
		/// <summary>
		/// Gets or sets Frame ID for frame owner elements and also for the document node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets The index of a frame owner element's content document in the <code>domNodes</code> array returned by <code>getSnapshot</code>, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ContentDocumentIndex { get; set; }
		/// <summary>
		/// Gets or sets Index of the imported document's node of a link element in the <code>domNodes</code> array returned by <code>getSnapshot</code>, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ImportedDocumentIndex { get; set; }
		/// <summary>
		/// Gets or sets Index of the content node of a template element in the <code>domNodes</code> array returned by <code>getSnapshot</code>.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? TemplateContentIndex { get; set; }
		/// <summary>
		/// Gets or sets Type of a pseudo element node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.PseudoType PseudoType { get; set; }
		/// <summary>
		/// Gets or sets Whether this DOM node responds to mouse clicks. This includes nodes that have had click event listeners attached via JavaScript as well as anchor tags that naturally navigate when clicked.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsClickable { get; set; }
	}
}
