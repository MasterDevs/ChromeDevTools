using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio{
	/// <summary>
	/// Enum of AudioNode::ChannelInterpretation from the spec
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChannelInterpretation
	{
			Discrete,
			Speakers,
	}
}
