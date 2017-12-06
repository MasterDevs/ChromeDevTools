using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Sets the new <code>text</code> for the respective style.
	/// </summary>
	[Command(ProtocolName.CSS.SetStyleText)]
	[SupportedBy("iOS")]
	public class SetStyleTextCommand: ICommand<SetStyleTextCommandResponse>
	{
		/// <summary>
		/// Gets or sets StyleId
		/// </summary>
		public CSSStyleId StyleId { get; set; }
		/// <summary>
		/// Gets or sets Text
		/// </summary>
		public string Text { get; set; }
	}
}
