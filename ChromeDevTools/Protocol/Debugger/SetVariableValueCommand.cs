using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Changes value of variable in a callframe or a closure. Either callframe or function must be specified. Object-based scopes are not supported and must be mutated manually.
	/// </summary>
	[Command(ProtocolName.Debugger.SetVariableValue)]
	public class SetVariableValueCommand
	{
		/// <summary>
		/// Gets or sets 0-based number of scope as was listed in scope chain. Only 'local', 'closure' and 'catch' scope types are allowed. Other scopes could be manipulated manually.
		/// </summary>
		public long ScopeNumber { get; set; }
		/// <summary>
		/// Gets or sets Variable name.
		/// </summary>
		public string VariableName { get; set; }
		/// <summary>
		/// Gets or sets New variable value.
		/// </summary>
		public Runtime.CallArgument NewValue { get; set; }
		/// <summary>
		/// Gets or sets Id of callframe that holds variable.
		/// </summary>
		public string CallFrameId { get; set; }
		/// <summary>
		/// Gets or sets Object id of closure (function) that holds variable.
		/// </summary>
		public string FunctionObjectId { get; set; }
	}
}
