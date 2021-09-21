using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Intercept file chooser requests and transfer control to protocol clients.
	/// When file chooser interception is enabled, native file chooser dialog is not shown.
	/// Instead, a protocol event `Page.fileChooserOpened` is emitted.
	/// </summary>
	[Command(ProtocolName.Page.SetInterceptFileChooserDialog)]
	[SupportedBy("Chrome")]
	public class SetInterceptFileChooserDialogCommand: ICommand<SetInterceptFileChooserDialogCommandResponse>
	{
		/// <summary>
		/// Gets or sets Enabled
		/// </summary>
		public bool Enabled { get; set; }
	}
}
