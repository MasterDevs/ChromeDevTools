using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Applies specified style edits one after another in the given order.
	/// </summary>
	[Command(ProtocolName.CSS.SetStyleTexts)]
	[SupportedBy("Chrome")]
	public class SetStyleTextsCommand: ICommand<SetStyleTextsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Edits
		/// </summary>
		public StyleDeclarationEdit[] Edits { get; set; }
	}
}
