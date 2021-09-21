using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Have one type per entry in MediaLogRecord::Type
	/// Corresponds to kMessage
	/// </summary>
	[SupportedBy("Chrome")]
	public class PlayerMessage
	{
		/// <summary>
		/// Gets or sets Keep in sync with MediaLogMessageLevel
		/// We are currently keeping the message level 'error' separate from the
		/// PlayerError type because right now they represent different things,
		/// This one being a DVLOG(ERROR) style log message that gets printed
		/// based on what log level is selected in the UI, and the other is a
		/// representation of a media::PipelineStatus object. Soon however we're
		/// going to be moving away from using PipelineStatus for errors and
		/// introducing a new error type which should hopefully let us integrate
		/// the error log level into the PlayerError type.
		/// </summary>
		public string Level { get; set; }
		/// <summary>
		/// Gets or sets Message
		/// </summary>
		public string Message { get; set; }
	}
}
