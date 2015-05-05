using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Returns root directory of the FileSystem, if exists.
	/// </summary>
	[Command(ProtocolName.FileSystem.RequestFileSystemRoot)]
	public class RequestFileSystemRootCommand
	{
		/// <summary>
		/// Gets or sets Security origin of requesting FileSystem. One of frames in current page needs to have this security origin.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets FileSystem type of requesting FileSystem.
		/// </summary>
		public string Type { get; set; }
	}
}
