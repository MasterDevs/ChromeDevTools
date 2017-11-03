using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	[SupportedBy("iOS")]
	public class Point
	{
		/// <summary>
		/// Gets or sets X
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y
		/// </summary>
		public double Y { get; set; }
	}
}
