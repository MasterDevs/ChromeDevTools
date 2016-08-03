using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	[Event(ProtocolName.Database.AddDatabase)]
	[SupportedBy("iOS")]
	public class AddDatabaseEvent
	{
		/// <summary>
		/// Gets or sets Database
		/// </summary>
		public Database Database { get; set; }
	}
}
