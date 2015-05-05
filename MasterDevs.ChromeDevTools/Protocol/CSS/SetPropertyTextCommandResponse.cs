using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Either replaces a property identified by <code>styleSheetId</code> and <code>range</code> with <code>text</code> or inserts a new property <code>text</code> at the position identified by an empty <code>range</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetPropertyText)]
	public class SetPropertyTextCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting style after the property text modification.
		/// </summary>
		public CSSStyle Style { get; set; }
	}
}
