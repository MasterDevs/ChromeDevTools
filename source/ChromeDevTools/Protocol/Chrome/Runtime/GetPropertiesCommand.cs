using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns properties of a given object. Object group of the result is inherited from the target object.
	/// </summary>
	[Command(ProtocolName.Runtime.GetProperties)]
	[SupportedBy("Chrome")]
	public class GetPropertiesCommand: ICommand<GetPropertiesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the object to return properties for.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets If true, returns properties belonging only to the element itself, not to its prototype chain.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? OwnProperties { get; set; }
		/// <summary>
		/// Gets or sets If true, returns accessor properties (with getter/setter) only; internal properties are not returned either.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AccessorPropertiesOnly { get; set; }
		/// <summary>
		/// Gets or sets Whether preview should be generated for the results.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
	}
}
