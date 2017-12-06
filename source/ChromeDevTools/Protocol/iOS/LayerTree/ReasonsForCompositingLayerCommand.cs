using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>
	[Command(ProtocolName.LayerTree.ReasonsForCompositingLayer)]
	[SupportedBy("iOS")]
	public class ReasonsForCompositingLayerCommand: ICommand<ReasonsForCompositingLayerCommandResponse>
	{
		/// <summary>
		/// Gets or sets The id of the layer for which we want to get the reasons it was composited.
		/// </summary>
		public string LayerId { get; set; }
	}
}
