using ChromeDevTools;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Fired when a canvas context has been created in the given frame. The context may not be instrumented (see hasUninstrumentedCanvases command).
	/// </summary>
	[Event(ProtocolName.Canvas.ContextCreated)]
	public class ContextCreatedEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing a canvas with a context.
		/// </summary>
		public string FrameId { get; set; }
	}
}
