using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Ensures that the given node will have specified pseudo-classes whenever its style is computed by the browser.
	/// </summary>
	[Command(ProtocolName.CSS.ForcePseudoState)]
	[SupportedBy("iOS")]
	public class ForcePseudoStateCommand: ICommand<ForcePseudoStateCommandResponse>
	{
		/// <summary>
		/// Gets or sets The element id for which to force the pseudo state.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Element pseudo classes to force when computing the element's style.
		/// </summary>
		public string[] ForcedPseudoClasses { get; set; }
	}
}
