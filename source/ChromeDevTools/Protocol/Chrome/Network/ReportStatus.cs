using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// The status of a Reporting API report.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReportStatus
	{
			Queued,
			Pending,
			MarkedForRemoval,
			Success,
	}
}
