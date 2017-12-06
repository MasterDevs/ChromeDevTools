using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Add handler to promise with given promise object id.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.AwaitPromise)]
	[SupportedBy("Chrome")]
	public class AwaitPromiseCommandResponse
	{
		/// <summary>
		/// Gets or sets Promise result. Will contain rejected value if promise was rejected.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets Exception details if stack strace is available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
