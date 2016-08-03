using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Returns properties of a given object. Object group of the result is inherited from the target object.
	/// </summary>
	[Command(ProtocolName.Runtime.GetProperties)]
	[SupportedBy("iOS")]
	public class GetPropertiesCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the object to return properties for.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets If true, returns properties belonging only to the object itself, not to its prototype chain.
		/// </summary>
		public bool OwnProperties { get; set; }
		/// <summary>
		/// Gets or sets Whether preview should be generated for property values.
		/// </summary>
		public bool GeneratePreview { get; set; }
	}
}
