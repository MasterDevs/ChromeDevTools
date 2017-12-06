using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets files for the given file input element.
	/// </summary>
	[Command(ProtocolName.DOM.SetFileInputFiles)]
	[SupportedBy("Chrome")]
	public class SetFileInputFilesCommand: ICommand<SetFileInputFilesCommandResponse>
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
