using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService{
	/// <summary>
	/// The Background Service that will be associated with the commands/events.
	/// Every Background Service operates independently, but they share the same
	/// API.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ServiceName
	{
			BackgroundFetch,
			BackgroundSync,
			PushMessaging,
			Notifications,
			PaymentHandler,
			PeriodicBackgroundSync,
	}
}
