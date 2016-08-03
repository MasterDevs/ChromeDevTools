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
		public string ClassName { get; set; }
		/// <summary>
		/// Gets or sets Size
		/// </summary>
		public Size Size { get; set; }
		/// <summary>
		/// Gets or sets Computed accessibility role for the element.
		/// </summary>
		public string Role { get; set; }
		/// <summary>
		/// Gets or sets RegionFlowData
		/// </summary>
		public RegionFlowData RegionFlowData { get; set; }
		/// <summary>
		/// Gets or sets ContentFlowData
		/// </summary>
		public ContentFlowData ContentFlowData { get; set; }
		/// <summary>
		/// Gets or sets ShapeOutsideData
		/// </summary>
		public ShapeOutsideData ShapeOutsideData { get; set; }
	}
}
