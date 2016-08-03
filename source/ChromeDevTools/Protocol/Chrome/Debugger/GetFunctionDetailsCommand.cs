using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns detailed information on given function.
	/// </summary>
	[Command(ProtocolName.Debugger.GetFunctionDetails)]
	[SupportedBy("Chrome")]
	public class GetFunctionDetailsCommand
	{
		/// <summary>
		/// Gets or sets Id of the function to get details for.
		/// </summary>
		public string FunctionId { get; set; }
	}
}
