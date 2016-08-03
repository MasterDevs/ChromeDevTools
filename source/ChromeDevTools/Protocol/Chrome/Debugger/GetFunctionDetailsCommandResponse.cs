using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns detailed information on given function.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetFunctionDetails)]
	[SupportedBy("Chrome")]
	public class GetFunctionDetailsCommandResponse
	{
		/// <summary>
		/// Gets or sets Information about the function.
		/// </summary>
		public FunctionDetails Details { get; set; }
	}
}
