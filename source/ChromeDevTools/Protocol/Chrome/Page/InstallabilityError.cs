using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// The installability error
	/// </summary>
	[SupportedBy("Chrome")]
	public class InstallabilityError
	{
		/// <summary>
		/// Gets or sets The error id (e.g. 'manifest-missing-suitable-icon').
		/// </summary>
		public string ErrorId { get; set; }
		/// <summary>
		/// Gets or sets The list of error arguments (e.g. {name:'minimum-icon-size-in-pixels', value:'64'}).
		/// </summary>
		public InstallabilityErrorArgument[] ErrorArguments { get; set; }
	}
}
