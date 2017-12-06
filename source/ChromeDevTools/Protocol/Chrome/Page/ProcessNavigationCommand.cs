using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Should be sent in response to a navigationRequested or a redirectRequested event, telling the browser how to handle the navigation.
	/// </summary>
	[Command(ProtocolName.Page.ProcessNavigation)]
	[SupportedBy("Chrome")]
	public class ProcessNavigationCommand: ICommand<ProcessNavigationCommandResponse>
	{
		/// <summary>
		/// Gets or sets Response
		/// </summary>
		public string Response { get; set; }
		/// <summary>
		/// Gets or sets NavigationId
		/// </summary>
		public long NavigationId { get; set; }
	}
}
