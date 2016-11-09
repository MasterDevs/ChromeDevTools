using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	/// <summary>
	/// Data that describes an element to be highlighted.
	/// </summary>
	[SupportedBy("iOS")]
	public class ElementData
	{
		/// <summary>
		/// Gets or sets TagName
		/// </summary>
		public string TagName { get; set; }
		/// <summary>
		/// Gets or sets The value of the element's 'id' attribute.
		/// </summary>
		public string IdValue { get; set; }
		/// <summary>
		/// Gets or sets ClassName
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ClassName { get; set; }
		/// <summary>
		/// Gets or sets Size
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Size Size { get; set; }
		/// <summary>
		/// Gets or sets Computed accessibility role for the element.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Role { get; set; }
		/// <summary>
		/// Gets or sets RegionFlowData
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RegionFlowData RegionFlowData { get; set; }
		/// <summary>
		/// Gets or sets ContentFlowData
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ContentFlowData ContentFlowData { get; set; }
		/// <summary>
		/// Gets or sets ShapeOutsideData
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ShapeOutsideData ShapeOutsideData { get; set; }
	}
}
