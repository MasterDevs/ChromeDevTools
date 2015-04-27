using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Gets supported tracing categories.
	/// </summary>
	[Command(ProtocolName.Tracing.GetCategories)]
	public class GetCategoriesCommand
	{
	}
}
