using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[Command(ProtocolName.Runtime.SetMaxCallStackSizeToCapture)]
	[SupportedBy("Chrome")]
	public class SetMaxCallStackSizeToCaptureCommand: ICommand<SetMaxCallStackSizeToCaptureCommandResponse>
	{
		/// <summary>
		/// Gets or sets Size
		/// </summary>
		public long Size { get; set; }
	}
}
