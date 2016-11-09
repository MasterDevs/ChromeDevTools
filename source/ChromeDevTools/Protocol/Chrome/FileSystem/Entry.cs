using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FileSystem
{
	/// <summary>
	/// Represents a browser side file or directory.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Entry
	{
		/// <summary>
		/// Gets or sets filesystem: URL for the entry.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets The name of the file or directory.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets True if the entry is a directory.
		/// </summary>
		public bool IsDirectory { get; set; }
		/// <summary>
		/// Gets or sets MIME type of the entry, available for a file only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or sets ResourceType of the entry, available for a file only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Page.ResourceType ResourceType { get; set; }
		/// <summary>
		/// Gets or sets True if the entry is a text file.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsTextFile { get; set; }
	}
}
