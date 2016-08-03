using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Event(ProtocolName.Worker.DisconnectedFromWorker)]
	[SupportedBy("iOS")]
	public class DisconnectedFromWorkerEvent
	{
	}
}
