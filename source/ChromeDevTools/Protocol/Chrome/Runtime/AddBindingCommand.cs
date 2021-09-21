using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// If executionContextId is empty, adds binding with the given name on the
	/// global objects of all inspected contexts, including those created later,
	/// bindings survive reloads.
	/// Binding function takes exactly one argument, this argument should be string,
	/// in case of any other input, function throws an exception.
	/// Each binding function call produces Runtime.bindingCalled notification.
	/// </summary>
	[Command(ProtocolName.Runtime.AddBinding)]
	[SupportedBy("Chrome")]
	public class AddBindingCommand: ICommand<AddBindingCommandResponse>
	{
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets If specified, the binding would only be exposed to the specified
		/// execution context. If omitted and `executionContextName` is not set,
		/// the binding is exposed to all execution contexts of the target.
		/// This parameter is mutually exclusive with `executionContextName`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ExecutionContextId { get; set; }
		/// <summary>
		/// Gets or sets If specified, the binding is exposed to the executionContext with
		/// matching name, even for contexts created after the binding is added.
		/// See also `ExecutionContext.name` and `worldName` parameter to
		/// `Page.addScriptToEvaluateOnNewDocument`.
		/// This parameter is mutually exclusive with `executionContextId`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ExecutionContextName { get; set; }
	}
}
