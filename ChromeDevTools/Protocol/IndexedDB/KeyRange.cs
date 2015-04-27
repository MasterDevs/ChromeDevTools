using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Key range.
	/// </summary>
	public class KeyRange
	{
		/// <summary>
		/// Gets or sets Lower bound.
		/// </summary>
		public Key Lower { get; set; }
		/// <summary>
		/// Gets or sets Upper bound.
		/// </summary>
		public Key Upper { get; set; }
		/// <summary>
		/// Gets or sets If true lower bound is open.
		/// </summary>
		public bool LowerOpen { get; set; }
		/// <summary>
		/// Gets or sets If true upper bound is open.
		/// </summary>
		public bool UpperOpen { get; set; }
	}
}
