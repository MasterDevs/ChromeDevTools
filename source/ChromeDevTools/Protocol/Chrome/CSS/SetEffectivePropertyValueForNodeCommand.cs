using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Find a rule with the given active property for the given node and set the new value for this property
	/// </summary>
	[Command(ProtocolName.CSS.SetEffectivePropertyValueForNode)]
	[SupportedBy("Chrome")]
	public class SetEffectivePropertyValueForNodeCommand: ICommand<SetEffectivePropertyValueForNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets The element id for which to set property.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets PropertyName
		/// </summary>
		public string PropertyName { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public string Value { get; set; }
	}
}
