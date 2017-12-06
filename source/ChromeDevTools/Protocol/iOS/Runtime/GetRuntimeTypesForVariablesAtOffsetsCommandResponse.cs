using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Returns detailed informtation on given function.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetRuntimeTypesForVariablesAtOffsets)]
	[SupportedBy("iOS")]
	public class GetRuntimeTypesForVariablesAtOffsetsCommandResponse
	{
		/// <summary>
		/// Gets or sets Types
		/// </summary>
		public TypeDescription[] Types { get; set; }
	}
}
