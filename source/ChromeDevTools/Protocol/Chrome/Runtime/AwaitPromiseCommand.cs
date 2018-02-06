using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Add handler to promise with given promise object id.
	/// </summary>
	[Command(ProtocolName.Runtime.AwaitPromise)]
	[SupportedBy("Chrome")]
	public class AwaitPromiseCommand: ICommand<AwaitPromiseCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the promise.
		/// </summary>
		public string PromiseObjectId { get; set; }
		/// <summary>
		/// Gets or sets Whether the result is expected to be a JSON object that should be sent by value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReturnByValue { get; set; }
		/// <summary>
		/// Gets or sets Whether preview should be generated for the result.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
	}
}
