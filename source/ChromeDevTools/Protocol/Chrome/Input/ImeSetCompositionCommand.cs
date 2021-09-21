using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// This method sets the current candidate text for ime.
	/// Use imeCommitComposition to commit the final text.
	/// Use imeSetComposition with empty string as text to cancel composition.
	/// </summary>
	[Command(ProtocolName.Input.ImeSetComposition)]
	[SupportedBy("Chrome")]
	public class ImeSetCompositionCommand: ICommand<ImeSetCompositionCommandResponse>
	{
		/// <summary>
		/// Gets or sets The text to insert
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets selection start
		/// </summary>
		public long SelectionStart { get; set; }
		/// <summary>
		/// Gets or sets selection end
		/// </summary>
		public long SelectionEnd { get; set; }
		/// <summary>
		/// Gets or sets replacement start
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ReplacementStart { get; set; }
		/// <summary>
		/// Gets or sets replacement end
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ReplacementEnd { get; set; }
	}
}
