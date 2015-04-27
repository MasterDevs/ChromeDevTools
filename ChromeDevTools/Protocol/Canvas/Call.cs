using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// 
	/// </summary>
	public class Call
	{
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets FunctionName
		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Arguments
		/// </summary>
		public CallArgument[] Arguments { get; set; }
		/// <summary>
		/// Gets or sets Result
		/// </summary>
		public CallArgument Result { get; set; }
		/// <summary>
		/// Gets or sets IsDrawingCall
		/// </summary>
		public bool IsDrawingCall { get; set; }
		/// <summary>
		/// Gets or sets IsFrameEndCall
		/// </summary>
		public bool IsFrameEndCall { get; set; }
		/// <summary>
		/// Gets or sets Property
		/// </summary>
		public string Property { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public CallArgument Value { get; set; }
		/// <summary>
		/// Gets or sets SourceURL
		/// </summary>
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets LineNumber
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets ColumnNumber
		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
