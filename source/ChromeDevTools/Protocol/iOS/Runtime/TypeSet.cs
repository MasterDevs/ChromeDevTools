using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	[SupportedBy("iOS")]
	public class TypeSet
	{
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Function.
		/// </summary>
		public bool IsFunction { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Undefined.
		/// </summary>
		public bool IsUndefined { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Null.
		/// </summary>
		public bool IsNull { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Boolean.
		/// </summary>
		public bool IsBoolean { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Integer.
		/// </summary>
		public bool IsInteger { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Number.
		/// </summary>
		public bool IsNumber { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type String.
		/// </summary>
		public bool IsString { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Object.
		/// </summary>
		public bool IsObject { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Symbol.
		/// </summary>
		public bool IsSymbol { get; set; }
	}
}
