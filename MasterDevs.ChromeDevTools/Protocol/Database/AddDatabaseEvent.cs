using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Database
{
	[Event(ProtocolName.Database.AddDatabase)]
	public class AddDatabaseEvent
	{
		/// <summary>
		/// Gets or sets Database
		/// </summary>
		public Database Database { get; set; }
	}
}
