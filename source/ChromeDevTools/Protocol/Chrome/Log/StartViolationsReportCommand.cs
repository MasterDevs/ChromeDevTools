using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// start violation reporting.
	/// </summary>
	[Command(ProtocolName.Log.StartViolationsReport)]
	[SupportedBy("Chrome")]
	public class StartViolationsReportCommand: ICommand<StartViolationsReportCommandResponse>
	{
		/// <summary>
		/// Gets or sets Configuration for violations.
		/// </summary>
		public ViolationSetting[] Config { get; set; }
	}
}
