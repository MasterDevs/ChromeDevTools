using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Returns content of the file. Result should be sliced into [start, end).
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.RequestFileContent)]
	public class RequestFileContentCommandResponse
	{
		/// <summary>
		/// Gets or sets 0, if no error. Otherwise, errorCode is set to FileError::ErrorCode value.
		/// </summary>
		public long ErrorCode { get; set; }
		/// <summary>
		/// Gets or sets Content of the file.
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// Gets or sets Charset of the content if it is served as text.
		/// </summary>
		public string Charset { get; set; }
	}
}
