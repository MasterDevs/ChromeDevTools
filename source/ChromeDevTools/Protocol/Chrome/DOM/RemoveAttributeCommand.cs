using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Removes attribute with given name from an element with given id.
	/// </summary>
	[Command(ProtocolName.DOM.RemoveAttribute)]
	[SupportedBy("Chrome")]
	public class RemoveAttributeCommand: ICommand<RemoveAttributeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the element to remove attribute from.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Name of the attribute to remove.
		/// </summary>
		public string Name { get; set; }
	}
}
