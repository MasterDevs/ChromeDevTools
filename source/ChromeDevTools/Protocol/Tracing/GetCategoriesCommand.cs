using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Gets supported tracing categories.
	/// </summary>
	[Command(ProtocolName.Tracing.GetCategories)]
	public class GetCategoriesCommand
	{
	}
}
