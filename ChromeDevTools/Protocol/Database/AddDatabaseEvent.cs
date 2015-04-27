using ChromeDevTools;

namespace ChromeDevTools.Protocol.Database
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
