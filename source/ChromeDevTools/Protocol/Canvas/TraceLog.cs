using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// 
	/// </summary>
	public class TraceLog
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Calls
		/// </summary>
		public Call[] Calls { get; set; }
		/// <summary>
		/// Gets or sets Contexts
		/// </summary>
		public CallArgument[] Contexts { get; set; }
		/// <summary>
		/// Gets or sets StartOffset
		/// </summary>
		public long StartOffset { get; set; }
		/// <summary>
		/// Gets or sets Alive
		/// </summary>
		public bool Alive { get; set; }
		/// <summary>
		/// Gets or sets TotalAvailableCalls
		/// </summary>
		public double TotalAvailableCalls { get; set; }
	}
}
