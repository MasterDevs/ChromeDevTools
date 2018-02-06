using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Returns detailed information on given function.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetFunctionDetails)]
	[SupportedBy("iOS")]
	public class GetFunctionDetailsCommandResponse
	{
		/// <summary>
		/// Gets or sets Information about the function.
		/// </summary>
		public FunctionDetails Details { get; set; }
	}
}
