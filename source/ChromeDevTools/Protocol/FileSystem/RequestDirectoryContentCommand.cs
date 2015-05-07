using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Returns content of the directory.
	/// </summary>
	[Command(ProtocolName.FileSystem.RequestDirectoryContent)]
	public class RequestDirectoryContentCommand
	{
		/// <summary>
		/// Gets or sets URL of the directory that the frontend is requesting to read from.
		/// </summary>
		public string Url { get; set; }
	}
}
