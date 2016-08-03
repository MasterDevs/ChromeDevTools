using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	/// <summary>
	/// Database error.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Error
	{
		/// <summary>
		/// Gets or sets Error message.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Error code.
		/// </summary>
		public long Code { get; set; }
	}
}
