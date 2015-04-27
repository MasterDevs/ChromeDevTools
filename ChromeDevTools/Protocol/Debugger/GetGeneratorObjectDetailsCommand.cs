using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns detailed information on given generator object.
	/// </summary>
	[Command(ProtocolName.Debugger.GetGeneratorObjectDetails)]
	public class GetGeneratorObjectDetailsCommand
	{
		/// <summary>
		/// Gets or sets Id of the generator object to get details for.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
