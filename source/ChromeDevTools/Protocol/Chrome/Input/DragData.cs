using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	[SupportedBy("Chrome")]
	public class DragData
	{
		/// <summary>
		/// Gets or sets Items
		/// </summary>
		public DragDataItem[] Items { get; set; }
		/// <summary>
		/// Gets or sets List of filenames that should be included when dropping
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Files { get; set; }
		/// <summary>
		/// Gets or sets Bit field representing allowed drag operations. Copy = 1, Link = 2, Move = 16
		/// </summary>
		public long DragOperationsMask { get; set; }
	}
}
