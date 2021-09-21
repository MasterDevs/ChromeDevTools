using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Adds the specified target to the list of targets that will be monitored for any related target
	/// creation (such as child frames, child workers and new versions of service worker) and reported
	/// through `attachedToTarget`. The specified target is also auto-attached.
	/// This cancels the effect of any previous `setAutoAttach` and is also cancelled by subsequent
	/// `setAutoAttach`. Only available at the Browser target.
	/// </summary>
	[Command(ProtocolName.Target.AutoAttachRelated)]
	[SupportedBy("Chrome")]
	public class AutoAttachRelatedCommand: ICommand<AutoAttachRelatedCommandResponse>
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
		/// <summary>
		/// Gets or sets Whether to pause new targets when attaching to them. Use `Runtime.runIfWaitingForDebugger`
		/// to run paused targets.
		/// </summary>
		public bool WaitForDebuggerOnStart { get; set; }
	}
}
