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
	[CommandResponse(ProtocolName.Runtime.AddBinding)]
	[SupportedBy("Chrome")]
	public class AddBindingCommandResponse
	{
	}
}
