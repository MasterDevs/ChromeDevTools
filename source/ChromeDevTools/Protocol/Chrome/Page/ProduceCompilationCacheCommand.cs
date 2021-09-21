using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Requests backend to produce compilation cache for the specified scripts.
	/// Unlike setProduceCompilationCache, this allows client to only produce cache
	/// for specific scripts. `scripts` are appeneded to the list of scripts
	/// for which the cache for would produced. Disabling compilation cache with
	/// `setProduceCompilationCache` would reset all pending cache requests.
	/// The list may also be reset during page navigation.
	/// When script with a matching URL is encountered, the cache is optionally
	/// produced upon backend discretion, based on internal heuristics.
	/// See also: `Page.compilationCacheProduced`.
	/// </summary>
	[Command(ProtocolName.Page.ProduceCompilationCache)]
	[SupportedBy("Chrome")]
	public class ProduceCompilationCacheCommand: ICommand<ProduceCompilationCacheCommandResponse>
	{
		/// <summary>
		/// Gets or sets Scripts
		/// </summary>
		public CompilationCacheParams[] Scripts { get; set; }
	}
}
