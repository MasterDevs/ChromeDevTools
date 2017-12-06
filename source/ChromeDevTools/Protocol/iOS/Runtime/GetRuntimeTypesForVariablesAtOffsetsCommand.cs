using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Returns detailed informtation on given function.
	/// </summary>
	[Command(ProtocolName.Runtime.GetRuntimeTypesForVariablesAtOffsets)]
	[SupportedBy("iOS")]
	public class GetRuntimeTypesForVariablesAtOffsetsCommand: ICommand<GetRuntimeTypesForVariablesAtOffsetsCommandResponse>
	{
		/// <summary>
		/// Gets or sets An array of type locations we're requesting information for. Results are expected in the same order they're sent in.
		/// </summary>
		public TypeLocation[] Locations { get; set; }
	}
}
