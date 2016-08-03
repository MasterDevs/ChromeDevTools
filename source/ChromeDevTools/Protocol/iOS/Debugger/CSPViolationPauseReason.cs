using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// The pause reason auxiliary data when paused because of a Content Security Policy directive.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSPViolationPauseReason
	{
		/// <summary>
		/// Gets or sets The CSP directive that blocked script execution.
		/// </summary>
		public string Directive { get; set; }
	}
}
