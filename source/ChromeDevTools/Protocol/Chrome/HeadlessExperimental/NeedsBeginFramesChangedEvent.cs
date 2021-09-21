using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Issued when the target starts or stops needing BeginFrames.
	/// Deprecated. Issue beginFrame unconditionally instead and use result from
	/// beginFrame to detect whether the frames were suppressed.
	/// </summary>
	[Event(ProtocolName.HeadlessExperimental.NeedsBeginFramesChanged)]
	[SupportedBy("Chrome")]
	public class NeedsBeginFramesChangedEvent
	{
		/// <summary>
		/// Gets or sets True if BeginFrames are needed, false otherwise.
		/// </summary>
		public bool NeedsBeginFrames { get; set; }
	}
}
