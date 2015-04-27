using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns detailed information on given function.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetFunctionDetails)]
	public class GetFunctionDetailsCommandResponse
	{
		/// <summary>
		/// Gets or sets Information about the function.
		/// </summary>
		public FunctionDetails Details { get; set; }
	}
}
