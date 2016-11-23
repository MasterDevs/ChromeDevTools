using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline{
	/// <summary>
	/// Timeline record type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EventType
	{
			EventDispatch,
			ScheduleStyleRecalculation,
			RecalculateStyles,
			InvalidateLayout,
			Layout,
			Paint,
			Composite,
			RenderingFrame,
			ScrollLayer,
			ParseHTML,
			TimerInstall,
			TimerRemove,
			TimerFire,
			EvaluateScript,
			MarkLoad,
			MarkDOMContent,
			TimeStamp,
			Time,
			TimeEnd,
			XHRReadyStateChange,
			XHRLoad,
			FunctionCall,
			ProbeSample,
			ConsoleProfile,
			GCEvent,
			RequestAnimationFrame,
			CancelAnimationFrame,
			FireAnimationFrame,
			WebSocketCreate,
			WebSocketSendHandshakeRequest,
			WebSocketReceiveHandshakeResponse,
			WebSocketDestroy,
	}
}
