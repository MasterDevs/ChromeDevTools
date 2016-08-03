using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FileSystem
{
	/// <summary>
	/// Represents metadata of a file or entry.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Metadata
	{
		/// <summary>
		/// Gets or sets Modification time.
		/// </summary>
		public double ModificationTime { get; set; }
		/// <summary>
		/// Gets or sets File size. This field is always zero for directories.
		/// </summary>
		public double Size { get; set; }
	}
}
