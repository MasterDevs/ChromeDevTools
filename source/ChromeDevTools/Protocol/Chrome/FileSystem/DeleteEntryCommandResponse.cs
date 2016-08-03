using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FileSystem
{
	/// <summary>
	/// Deletes specified entry. If the entry is a directory, the agent deletes children recursively.
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.DeleteEntry)]
	[SupportedBy("Chrome")]
	public class DeleteEntryCommandResponse
	{
		/// <summary>
		/// Gets or sets 0, if no error. Otherwise errorCode is set to FileError::ErrorCode value.
		/// </summary>
		public long ErrorCode { get; set; }
	}
}
