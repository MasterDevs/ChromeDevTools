using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	[CommandResponse(ProtocolName.Canvas.GetResourceState)]
	public class GetResourceStateCommandResponse
	{
		/// <summary>
		/// Gets or sets ResourceState
		/// </summary>
		public ResourceState ResourceState { get; set; }
	}
}
