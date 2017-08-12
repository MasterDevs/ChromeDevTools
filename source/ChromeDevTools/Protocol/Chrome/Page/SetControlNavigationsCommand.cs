using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Toggles navigation throttling which allows programatic control over navigation and redirect response.
	/// </summary>
	[Command(ProtocolName.Page.SetControlNavigations)]
	[SupportedBy("Chrome")]
	public class SetControlNavigationsCommand: ICommand<SetControlNavigationsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Enabled
		/// </summary>
		public bool Enabled { get; set; }
	}
}
