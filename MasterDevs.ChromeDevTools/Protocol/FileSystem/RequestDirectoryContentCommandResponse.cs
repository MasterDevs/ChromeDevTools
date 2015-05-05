using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Returns content of the directory.
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.RequestDirectoryContent)]
	public class RequestDirectoryContentCommandResponse
	{
		/// <summary>
		/// Gets or sets 0, if no error. Otherwise, errorCode is set to FileError::ErrorCode value.
		/// </summary>
		public long ErrorCode { get; set; }
		/// <summary>
		/// Gets or sets Contains all entries on directory if the command completed successfully.
		/// </summary>
		public Entry[] Entries { get; set; }
	}
}
