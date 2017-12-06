using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Controls the visibility of compositing borders.
	/// </summary>
	[Command(ProtocolName.Page.SetCompositingBordersVisible)]
	[SupportedBy("iOS")]
	public class SetCompositingBordersVisibleCommand: ICommand<SetCompositingBordersVisibleCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing compositing borders.
		/// </summary>
		public bool Visible { get; set; }
	}
}
