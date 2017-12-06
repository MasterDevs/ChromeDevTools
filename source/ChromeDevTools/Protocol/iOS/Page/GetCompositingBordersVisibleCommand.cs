using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Indicates the visibility of compositing borders.
	/// </summary>
	[Command(ProtocolName.Page.GetCompositingBordersVisible)]
	[SupportedBy("iOS")]
	public class GetCompositingBordersVisibleCommand: ICommand<GetCompositingBordersVisibleCommandResponse>
	{
	}
}
