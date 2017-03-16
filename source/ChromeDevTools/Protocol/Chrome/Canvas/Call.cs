using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome")]
	public class Call
	{
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets FunctionName
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Arguments
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallArgument[] Arguments { get; set; }
		/// <summary>
		/// Gets or sets Result
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallArgument Result { get; set; }
		/// <summary>
		/// Gets or sets IsDrawingCall
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsDrawingCall { get; set; }
		/// <summary>
		/// Gets or sets IsFrameEndCall
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsFrameEndCall { get; set; }
		/// <summary>
		/// Gets or sets Property
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Property { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallArgument Value { get; set; }
		/// <summary>
		/// Gets or sets SourceURL
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets LineNumber
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? LineNumber { get; set; }
		/// <summary>
		/// Gets or sets ColumnNumber
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ColumnNumber { get; set; }
	}
}
