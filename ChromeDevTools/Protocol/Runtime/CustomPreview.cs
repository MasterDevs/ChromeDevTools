using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// 
	/// </summary>
	public class CustomPreview
	{
		/// <summary>
		/// Gets or sets Header
		/// </summary>
		public string Header { get; set; }
		/// <summary>
		/// Gets or sets HasBody
		/// </summary>
		public bool HasBody { get; set; }
		/// <summary>
		/// Gets or sets FormatterObjectId
		/// </summary>
		public string FormatterObjectId { get; set; }
		/// <summary>
		/// Gets or sets ConfigObjectId
		/// </summary>
		public string ConfigObjectId { get; set; }
	}
}
