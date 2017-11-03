using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Resizes the frame/viewport of the page. Note that this does not affect the frame's container (e.g. browser window). Can be used to produce screenshots of the specified size. Not supported on Android.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Emulation.SetVisibleSize)]
	[SupportedBy("Chrome")]
	public class SetVisibleSizeCommand: ICommand<SetVisibleSizeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Frame width (DIP).
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Frame height (DIP).
		/// </summary>
		public long Height { get; set; }
	}
}
