using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns detailed information on given generator object.
	/// </summary>
	[Command(ProtocolName.Debugger.GetGeneratorObjectDetails)]
	[SupportedBy("Chrome")]
	public class GetGeneratorObjectDetailsCommand
	{
		/// <summary>
		/// Gets or sets Id of the generator object to get details for.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
