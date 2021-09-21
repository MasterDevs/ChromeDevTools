using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MixedContentResourceType
	{
			Audio,
			Beacon,
			CSPReport,
			Download,
			EventSource,
			Favicon,
			Font,
			Form,
			Frame,
			Image,
			Import,
			Manifest,
			Ping,
			PluginData,
			PluginResource,
			Prefetch,
			Resource,
			Script,
			ServiceWorker,
			SharedWorker,
			Stylesheet,
			Track,
			Video,
			Worker,
			XMLHttpRequest,
			XSLT,
	}
}
