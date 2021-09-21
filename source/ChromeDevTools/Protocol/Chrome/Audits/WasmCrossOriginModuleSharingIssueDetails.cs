using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class WasmCrossOriginModuleSharingIssueDetails
	{
		/// <summary>
		/// Gets or sets WasmModuleUrl
		/// </summary>
		public string WasmModuleUrl { get; set; }
		/// <summary>
		/// Gets or sets SourceOrigin
		/// </summary>
		public string SourceOrigin { get; set; }
		/// <summary>
		/// Gets or sets TargetOrigin
		/// </summary>
		public string TargetOrigin { get; set; }
		/// <summary>
		/// Gets or sets IsWarning
		/// </summary>
		public bool IsWarning { get; set; }
	}
}
