using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// DOM interaction is implemented in terms of mirror objects that represent the actual DOM nodes. DOMNode is a base node mirror type.
	/// </summary>
	public class Node
	{
		/// <summary>
		/// Gets or sets Node identifier that is passed into the rest of the DOM messages as the <code>nodeId</code>. Backend will only push node with given <code>id</code> once. It is aware of all requested nodes and will only fire DOM events for nodes known to the client.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeType.
		/// </summary>
		public long NodeType { get; set; }
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeName.
		/// </summary>
		public string NodeName { get; set; }
		/// <summary>
		/// Gets or sets <code>Node</code>'s localName.
		/// </summary>
		public string LocalName { get; set; }
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeValue.
		/// </summary>
		public string NodeValue { get; set; }
		/// <summary>
		/// Gets or sets Child count for <code>Container</code> nodes.
		/// </summary>
		public long ChildNodeCount { get; set; }
		/// <summary>
		/// Gets or sets Child nodes of this node when requested with children.
		/// </summary>
		public Node[] Children { get; set; }
		/// <summary>
		/// Gets or sets Attributes of the <code>Element</code> node in the form of flat array <code>[name1, value1, name2, value2]</code>.
		/// </summary>
		public string[] Attributes { get; set; }
		/// <summary>
		/// Gets or sets Document URL that <code>Document</code> or <code>FrameOwner</code> node points to.
		/// </summary>
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or sets Base URL that <code>Document</code> or <code>FrameOwner</code> node uses for URL completion.
		/// </summary>
		public string BaseURL { get; set; }
		/// <summary>
		/// Gets or sets <code>DocumentType</code>'s publicId.
		/// </summary>
		public string PublicId { get; set; }
		/// <summary>
		/// Gets or sets <code>DocumentType</code>'s systemId.
		/// </summary>
		public string SystemId { get; set; }
		/// <summary>
		/// Gets or sets <code>DocumentType</code>'s internalSubset.
		/// </summary>
		public string InternalSubset { get; set; }
		/// <summary>
		/// Gets or sets <code>Document</code>'s XML version in case of XML documents.
		/// </summary>
		public string XmlVersion { get; set; }
		/// <summary>
		/// Gets or sets <code>Attr</code>'s name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets <code>Attr</code>'s value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Pseudo element type for this node.
		/// </summary>
		public PseudoType PseudoType { get; set; }
		/// <summary>
		/// Gets or sets Shadow root type.
		/// </summary>
		public ShadowRootType ShadowRootType { get; set; }
		/// <summary>
		/// Gets or sets Frame ID for frame owner elements.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Content document for frame owner elements.
		/// </summary>
		public Node ContentDocument { get; set; }
		/// <summary>
		/// Gets or sets Shadow root list for given element host.
		/// </summary>
		public Node[] ShadowRoots { get; set; }
		/// <summary>
		/// Gets or sets Content document fragment for template elements.
		/// </summary>
		public Node TemplateContent { get; set; }
		/// <summary>
		/// Gets or sets Pseudo elements associated with this node.
		/// </summary>
		public Node[] PseudoElements { get; set; }
		/// <summary>
		/// Gets or sets Import document for the HTMLImport links.
		/// </summary>
		public Node ImportedDocument { get; set; }
		/// <summary>
		/// Gets or sets Distributed nodes for given insertion point.
		/// </summary>
		public BackendNode[] DistributedNodes { get; set; }
	}
}
