using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns detailed information on given generator object.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetGeneratorObjectDetails)]
	public class GetGeneratorObjectDetailsCommandResponse
	{
		/// <summary>
		/// Gets or sets Information about the generator object.
		/// </summary>
		public GeneratorObjectDetails Details { get; set; }
	}
}
