using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Deletes browser cookies with matching name and url or domain/path pair.
	/// </summary>
	[Command(ProtocolName.Network.DeleteCookies)]
	[SupportedBy("Chrome")]
	public class DeleteCookiesCommand: ICommand<DeleteCookiesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Name of the cookies to remove.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets If specified, deletes all the cookies with the given name where domain and path match provided URL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets If specified, deletes only cookies with the exact domain.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets If specified, deletes only cookies with the exact path.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Path { get; set; }
	}
}
