using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Error data for setScriptSource command. compileError is a case type for uncompilable script source error.
	/// </summary>
	public class SetScriptSourceError
	{
		/// <summary>
		/// Gets or sets CompileError
		/// </summary>
		public object CompileError { get; set; }
	}
}
