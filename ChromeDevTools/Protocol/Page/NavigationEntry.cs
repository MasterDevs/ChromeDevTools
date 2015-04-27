using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Navigation history entry.
	/// </summary>
	public class NavigationEntry
	{
		/// <summary>
		/// Gets or sets Unique id of the navigation history entry.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets URL of the navigation history entry.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Title of the navigation history entry.
		/// </summary>
		public string Title { get; set; }
	}
}
