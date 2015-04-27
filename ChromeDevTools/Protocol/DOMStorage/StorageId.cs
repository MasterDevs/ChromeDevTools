using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMStorage
{
	/// <summary>
	/// DOM Storage identifier.
	/// </summary>
	public class StorageId
	{
		/// <summary>
		/// Gets or sets Security origin for the storage.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Whether the storage is local storage (not session storage).
		/// </summary>
		public bool IsLocalStorage { get; set; }
	}
}
