using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	/// <summary>
	/// DOM Storage identifier.
	/// </summary>
	[SupportedBy("Chrome")]
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
