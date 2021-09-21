using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Changes return value in top frame. Available only at return break position.
	/// </summary>
	[Command(ProtocolName.Debugger.SetReturnValue)]
	[SupportedBy("Chrome")]
	public class SetReturnValueCommand: ICommand<SetReturnValueCommandResponse>
	{
		/// <summary>
		/// Gets or sets New return value.
		/// </summary>
		public Runtime.CallArgument NewValue { get; set; }
	}
}
