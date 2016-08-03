using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Calls function with given declaration on the given object. Object group of the result is inherited from the target object.
	/// </summary>
	[Command(ProtocolName.Runtime.CallFunctionOn)]
	[SupportedBy("Chrome")]
	public class CallFunctionOnCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the object to call function on.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Declaration of the function to call.
		/// </summary>
		public string FunctionDeclaration { get; set; }
		/// <summary>
		/// Gets or sets Call arguments. All call arguments must belong to the same JavaScript world as the target object.
		/// </summary>
		public CallArgument[] Arguments { get; set; }
		/// <summary>
		/// Gets or sets Specifies whether function call should stop on exceptions and mute console. Overrides setPauseOnException state.
		/// </summary>
		public bool DoNotPauseOnExceptionsAndMuteConsole { get; set; }
		/// <summary>
		/// Gets or sets Whether the result is expected to be a JSON object which should be sent by value.
		/// </summary>
		public bool ReturnByValue { get; set; }
		/// <summary>
		/// Gets or sets Whether preview should be generated for the result.
		/// </summary>
		public bool GeneratePreview { get; set; }
	}
}
