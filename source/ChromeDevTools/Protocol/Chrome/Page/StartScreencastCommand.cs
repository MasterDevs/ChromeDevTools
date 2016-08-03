using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Starts sending each frame using the <code>screencastFrame</code> event.
	/// </summary>
	[Command(ProtocolName.Page.StartScreencast)]
	[SupportedBy("Chrome")]
	public class StartScreencastCommand
	{
		/// <summary>
		/// Gets or sets Image compression format.
		/// </summary>
		public string Format { get; set; }
		/// <summary>
		/// Gets or sets Compression quality from range [0..100].
		/// </summary>
		public long Quality { get; set; }
		/// <summary>
		/// Gets or sets Maximum screenshot width.
		/// </summary>
		public long MaxWidth { get; set; }
		/// <summary>
		/// Gets or sets Maximum screenshot height.
		/// </summary>
		public long MaxHeight { get; set; }
	}
}
