using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Prevents default drag and drop behavior and instead emits `Input.dragIntercepted` events.
	/// Drag and drop behavior can be directly controlled via `Input.dispatchDragEvent`.
	/// </summary>
	[Command(ProtocolName.Input.SetInterceptDrags)]
	[SupportedBy("Chrome")]
	public class SetInterceptDragsCommand: ICommand<SetInterceptDragsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Enabled
		/// </summary>
		public bool Enabled { get; set; }
	}
}
