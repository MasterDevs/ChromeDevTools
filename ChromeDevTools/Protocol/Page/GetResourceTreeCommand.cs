using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>
	[Command(ProtocolName.Page.GetResourceTree)]
	public class GetResourceTreeCommand
	{
	}
}
