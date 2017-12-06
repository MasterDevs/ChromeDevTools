using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the keyframe rule key text.
	/// </summary>
	[Command(ProtocolName.CSS.SetKeyframeKey)]
	[SupportedBy("Chrome")]
	public class SetKeyframeKeyCommand: ICommand<SetKeyframeKeyCommandResponse>
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Range
		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets KeyText
		/// </summary>
		public string KeyText { get; set; }
	}
}
