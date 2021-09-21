using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PermissionType
	{
			AccessibilityEvents,
			AudioCapture,
			BackgroundSync,
			BackgroundFetch,
			ClipboardReadWrite,
			ClipboardSanitizedWrite,
			DisplayCapture,
			DurableStorage,
			Flash,
			Geolocation,
			Midi,
			MidiSysex,
			Nfc,
			Notifications,
			PaymentHandler,
			PeriodicBackgroundSync,
			ProtectedMediaIdentifier,
			Sensors,
			VideoCapture,
			VideoCapturePanTiltZoom,
			IdleDetection,
			WakeLockScreen,
			WakeLockSystem,
	}
}
