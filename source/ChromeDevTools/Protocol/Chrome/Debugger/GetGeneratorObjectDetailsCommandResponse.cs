using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns detailed information on given generator object.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetGeneratorObjectDetails)]
	[SupportedBy("Chrome")]
	public class GetGeneratorObjectDetailsCommandResponse
	{
		/// <summary>
		/// Gets or sets Information about the generator object.
		/// </summary>
		public GeneratorObjectDetails Details { get; set; }
	}
}
