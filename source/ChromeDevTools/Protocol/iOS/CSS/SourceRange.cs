using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Text range within a resource.
	/// </summary>
	[SupportedBy("iOS")]
	public class SourceRange
	{
		/// <summary>
		/// Gets or sets Start line of range.
		/// </summary>
		public long StartLine { get; set; }
		/// <summary>
		/// Gets or sets Start column of range (inclusive).
		/// </summary>
		public long StartColumn { get; set; }
		/// <summary>
		/// Gets or sets End line of range
		/// </summary>
		public long EndLine { get; set; }
		/// <summary>
		/// Gets or sets End column of range (exclusive).
		/// </summary>
		public long EndColumn { get; set; }
	}
}
