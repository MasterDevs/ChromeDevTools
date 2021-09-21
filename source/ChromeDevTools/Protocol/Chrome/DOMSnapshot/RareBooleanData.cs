using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	[SupportedBy("Chrome")]
	public class RareBooleanData
	{
		/// <summary>
		/// Gets or sets Index
		/// </summary>
		public long[] Index { get; set; }
	}
}
