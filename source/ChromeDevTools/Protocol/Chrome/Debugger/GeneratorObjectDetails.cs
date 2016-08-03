using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Information about the generator object.
	/// </summary>
	[SupportedBy("Chrome")]
	public class GeneratorObjectDetails
	{
		/// <summary>
		/// Gets or sets Generator function.
		/// </summary>
		public Runtime.RemoteObject Function { get; set; }
		/// <summary>
		/// Gets or sets Name of the generator function.
		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Current generator object status.
		/// </summary>
		public string Status { get; set; }
		/// <summary>
		/// Gets or sets If suspended, location where generator function was suspended (e.g. location of the last 'yield'). Otherwise, location of the generator function.
		/// </summary>
		public Location Location { get; set; }
	}
}
