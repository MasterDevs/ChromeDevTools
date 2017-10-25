using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Transition type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TransitionType
	{
			Link,
			Typed,
			Auto_bookmark,
			Auto_subframe,
			Manual_subframe,
			Generated,
			Auto_toplevel,
			Form_submit,
			Reload,
			Keyword,
			Keyword_generated,
			Other,
	}
}
