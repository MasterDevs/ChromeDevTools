using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Returns root directory of the FileSystem, if exists.
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.RequestFileSystemRoot)]
	public class RequestFileSystemRootCommandResponse
	{
		/// <summary>
		/// Gets or sets 0, if no error. Otherwise, errorCode is set to FileError::ErrorCode value.
		/// </summary>
		public long ErrorCode { get; set; }
		/// <summary>
		/// Gets or sets Contains root of the requested FileSystem if the command completed successfully.
		/// </summary>
		public Entry Root { get; set; }
	}
}
