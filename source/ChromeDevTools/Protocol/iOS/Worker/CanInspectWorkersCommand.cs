using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	/// <summary>
	/// Tells whether browser supports workers inspection.
	/// </summary>
	[Command(ProtocolName.Worker.CanInspectWorkers)]
	[SupportedBy("iOS")]
	public class CanInspectWorkersCommand: ICommand<CanInspectWorkersCommandResponse>
	{
	}
}
