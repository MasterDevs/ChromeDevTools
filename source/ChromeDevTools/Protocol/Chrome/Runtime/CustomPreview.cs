using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[SupportedBy("Chrome")]
	public class CustomPreview
	{
		/// <summary>
		/// Gets or sets The JSON-stringified result of formatter.header(object, config) call.
		/// It contains json ML array that represents RemoteObject.
		/// </summary>
		public string Header { get; set; }
		/// <summary>
		/// Gets or sets If formatter returns true as a result of formatter.hasBody call then bodyGetterId will
		/// contain RemoteObjectId for the function that returns result of formatter.body(object, config) call.
		/// The result value is json ML array.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BodyGetterId { get; set; }
	}
}
