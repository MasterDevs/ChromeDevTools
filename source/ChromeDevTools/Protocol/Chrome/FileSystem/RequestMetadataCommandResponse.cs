using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FileSystem
{
	/// <summary>
	/// Returns metadata of the entry.
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.RequestMetadata)]
	[SupportedBy("Chrome")]
	public class RequestMetadataCommandResponse
	{
		/// <summary>
		/// Gets or sets 0, if no error. Otherwise, errorCode is set to FileError::ErrorCode value.
		/// </summary>
		public long ErrorCode { get; set; }
		/// <summary>
		/// Gets or sets Contains metadata of the entry if the command completed successfully.
		/// </summary>
		public Metadata Metadata { get; set; }
	}
}
