using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Gets supported tracing categories.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.GetCategories)]
	public class GetCategoriesCommandResponse
	{
		/// <summary>
		/// Gets or sets A list of supported tracing categories.
		/// </summary>
		public string[] Categories { get; set; }
	}
}
