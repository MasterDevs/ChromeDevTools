using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Set generic font families.
	/// </summary>
	[Command(ProtocolName.Page.SetFontFamilies)]
	[SupportedBy("Chrome")]
	public class SetFontFamiliesCommand: ICommand<SetFontFamiliesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Specifies font families to set. If a font family is not specified, it won't be changed.
		/// </summary>
		public FontFamilies FontFamilies { get; set; }
	}
}
