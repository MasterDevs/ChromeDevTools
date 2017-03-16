using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Information about the promise.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PromiseDetails
	{
		/// <summary>
		/// Gets or sets Unique id of the promise.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets Status of the promise.
		/// </summary>
		public string Status { get; set; }
		/// <summary>
		/// Gets or sets Id of the parent promise.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ParentId { get; set; }
		/// <summary>
		/// Gets or sets Top call frame on promise creation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Console.CallFrame CallFrame { get; set; }
		/// <summary>
		/// Gets or sets Creation time of the promise.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double CreationTime { get; set; }
		/// <summary>
		/// Gets or sets Settlement time of the promise.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double SettlementTime { get; set; }
		/// <summary>
		/// Gets or sets JavaScript stack trace on promise creation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Console.CallFrame[] CreationStack { get; set; }
		/// <summary>
		/// Gets or sets JavaScript asynchronous stack trace on promise creation, if available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Console.AsyncStackTrace AsyncCreationStack { get; set; }
		/// <summary>
		/// Gets or sets JavaScript stack trace on promise settlement.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Console.CallFrame[] SettlementStack { get; set; }
		/// <summary>
		/// Gets or sets JavaScript asynchronous stack trace on promise settlement, if available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Console.AsyncStackTrace AsyncSettlementStack { get; set; }
	}
}
