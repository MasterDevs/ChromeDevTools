using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Corresponds to kMediaError
	/// </summary>
	[SupportedBy("Chrome")]
	public class PlayerError
	{
		/// <summary>
		/// Gets or sets Type
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets When this switches to using media::Status instead of PipelineStatus
		/// we can remove "errorCode" and replace it with the fields from
		/// a Status instance. This also seems like a duplicate of the error
		/// level enum - there is a todo bug to have that level removed and
		/// use this instead. (crbug.com/1068454)
		/// </summary>
		public string ErrorCode { get; set; }
	}
}
