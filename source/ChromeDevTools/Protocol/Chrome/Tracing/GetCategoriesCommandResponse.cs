using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Gets supported tracing categories.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.GetCategories)]
	[SupportedBy("Chrome")]
	public class GetCategoriesCommandResponse
	{
		/// <summary>
		/// Gets or sets A list of supported tracing categories.
		/// </summary>
		public string[] Categories { get; set; }
	}
}
