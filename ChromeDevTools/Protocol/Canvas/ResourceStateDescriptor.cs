using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Resource state descriptor.
	/// </summary>
	public class ResourceStateDescriptor
	{
		/// <summary>
		/// Gets or sets State name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets String representation of the enum value, if <code>name</code> stands for an enum.
		/// </summary>
		public string EnumValueForName { get; set; }
		/// <summary>
		/// Gets or sets The value associated with the particular state.
		/// </summary>
		public CallArgument Value { get; set; }
		/// <summary>
		/// Gets or sets Array of values associated with the particular state. Either <code>value</code> or <code>values</code> will be specified.
		/// </summary>
		public ResourceStateDescriptor[] Values { get; set; }
		/// <summary>
		/// Gets or sets True iff the given <code>values</code> items stand for an array rather than a list of grouped states.
		/// </summary>
		public bool IsArray { get; set; }
	}
}
