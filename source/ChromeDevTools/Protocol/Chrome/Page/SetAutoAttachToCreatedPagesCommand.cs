using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Controls whether browser will open a new inspector window for connected pages.
	/// </summary>
	[Command(ProtocolName.Page.SetAutoAttachToCreatedPages)]
	[SupportedBy("Chrome")]
	public class SetAutoAttachToCreatedPagesCommand: ICommand<SetAutoAttachToCreatedPagesCommandResponse>
	{
		/// <summary>
		/// Gets or sets If true, browser will open a new inspector window for every page created from this one.
		/// </summary>
		public bool AutoAttach { get; set; }
	}
}
