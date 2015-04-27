using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets files for the given file input element.
	/// </summary>
	[Command(ProtocolName.DOM.SetFileInputFiles)]
	public class SetFileInputFilesCommand
	{
		/// <summary>
		/// Gets or sets Id of the file input node to set files for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Array of file paths to set.
		/// </summary>
		public string[] Files { get; set; }
	}
}
