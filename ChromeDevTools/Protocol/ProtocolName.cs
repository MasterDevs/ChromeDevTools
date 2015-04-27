using ChromeDevTools;

namespace ChromeDevTools.Protocol
{
	public static class ProtocolName
	{
		public static class Inspector
		{
			public const string Enable = "Inspector.enable";
			public const string Disable = "Inspector.disable";
			public const string EvaluateForTestInFrontend = "Inspector.evaluateForTestInFrontend";
			public const string Inspect = "Inspector.inspect";
			public const string Detached = "Inspector.detached";
			public const string TargetCrashed = "Inspector.targetCrashed";
		}

		public static class Memory
		{
			public const string GetDOMCounters = "Memory.getDOMCounters";
		}

		public static class Page
		{
			public const string Enable = "Page.enable";
			public const string Disable = "Page.disable";
			public const string AddScriptToEvaluateOnLoad = "Page.addScriptToEvaluateOnLoad";
			public const string RemoveScriptToEvaluateOnLoad = "Page.removeScriptToEvaluateOnLoad";
			public const string Reload = "Page.reload";
			public const string Navigate = "Page.navigate";
			public const string GetNavigationHistory = "Page.getNavigationHistory";
			public const string NavigateToHistoryEntry = "Page.navigateToHistoryEntry";
			public const string GetCookies = "Page.getCookies";
			public const string DeleteCookie = "Page.deleteCookie";
			public const string GetResourceTree = "Page.getResourceTree";
			public const string GetResourceContent = "Page.getResourceContent";
			public const string SearchInResource = "Page.searchInResource";
			public const string SetDocumentContent = "Page.setDocumentContent";
			public const string SetDeviceMetricsOverride = "Page.setDeviceMetricsOverride";
			public const string ClearDeviceMetricsOverride = "Page.clearDeviceMetricsOverride";
			public const string SetGeolocationOverride = "Page.setGeolocationOverride";
			public const string ClearGeolocationOverride = "Page.clearGeolocationOverride";
			public const string SetDeviceOrientationOverride = "Page.setDeviceOrientationOverride";
			public const string ClearDeviceOrientationOverride = "Page.clearDeviceOrientationOverride";
			public const string SetTouchEmulationEnabled = "Page.setTouchEmulationEnabled";
			public const string CaptureScreenshot = "Page.captureScreenshot";
			public const string CanScreencast = "Page.canScreencast";
			public const string StartScreencast = "Page.startScreencast";
			public const string StopScreencast = "Page.stopScreencast";
			public const string ScreencastFrameAck = "Page.screencastFrameAck";
			public const string HandleJavaScriptDialog = "Page.handleJavaScriptDialog";
			public const string SetShowViewportSizeOnResize = "Page.setShowViewportSizeOnResize";
			public const string SetColorPickerEnabled = "Page.setColorPickerEnabled";
			public const string SetOverlayMessage = "Page.setOverlayMessage";
			public const string DomContentEventFired = "Page.domContentEventFired";
			public const string LoadEventFired = "Page.loadEventFired";
			public const string FrameAttached = "Page.frameAttached";
			public const string FrameNavigated = "Page.frameNavigated";
			public const string FrameDetached = "Page.frameDetached";
			public const string FrameStartedLoading = "Page.frameStartedLoading";
			public const string FrameStoppedLoading = "Page.frameStoppedLoading";
			public const string FrameScheduledNavigation = "Page.frameScheduledNavigation";
			public const string FrameClearedScheduledNavigation = "Page.frameClearedScheduledNavigation";
			public const string FrameResized = "Page.frameResized";
			public const string JavascriptDialogOpening = "Page.javascriptDialogOpening";
			public const string JavascriptDialogClosed = "Page.javascriptDialogClosed";
			public const string ScreencastFrame = "Page.screencastFrame";
			public const string ScreencastVisibilityChanged = "Page.screencastVisibilityChanged";
			public const string ColorPicked = "Page.colorPicked";
			public const string InterstitialShown = "Page.interstitialShown";
			public const string InterstitialHidden = "Page.interstitialHidden";
		}

		public static class Rendering
		{
			public const string SetShowPaintRects = "Rendering.setShowPaintRects";
			public const string SetShowDebugBorders = "Rendering.setShowDebugBorders";
			public const string SetShowFPSCounter = "Rendering.setShowFPSCounter";
			public const string SetContinuousPaintingEnabled = "Rendering.setContinuousPaintingEnabled";
			public const string SetShowScrollBottleneckRects = "Rendering.setShowScrollBottleneckRects";
		}

		public static class Emulation
		{
			public const string SetDeviceMetricsOverride = "Emulation.setDeviceMetricsOverride";
			public const string ClearDeviceMetricsOverride = "Emulation.clearDeviceMetricsOverride";
			public const string ResetScrollAndPageScaleFactor = "Emulation.resetScrollAndPageScaleFactor";
			public const string SetPageScaleFactor = "Emulation.setPageScaleFactor";
			public const string SetScriptExecutionDisabled = "Emulation.setScriptExecutionDisabled";
			public const string SetGeolocationOverride = "Emulation.setGeolocationOverride";
			public const string ClearGeolocationOverride = "Emulation.clearGeolocationOverride";
			public const string SetTouchEmulationEnabled = "Emulation.setTouchEmulationEnabled";
			public const string SetEmulatedMedia = "Emulation.setEmulatedMedia";
			public const string CanEmulate = "Emulation.canEmulate";
			public const string ViewportChanged = "Emulation.viewportChanged";
		}

		public static class Runtime
		{
			public const string Evaluate = "Runtime.evaluate";
			public const string CallFunctionOn = "Runtime.callFunctionOn";
			public const string GetProperties = "Runtime.getProperties";
			public const string GetEventListeners = "Runtime.getEventListeners";
			public const string ReleaseObject = "Runtime.releaseObject";
			public const string ReleaseObjectGroup = "Runtime.releaseObjectGroup";
			public const string Run = "Runtime.run";
			public const string Enable = "Runtime.enable";
			public const string Disable = "Runtime.disable";
			public const string IsRunRequired = "Runtime.isRunRequired";
			public const string SetCustomObjectFormatterEnabled = "Runtime.setCustomObjectFormatterEnabled";
			public const string ExecutionContextCreated = "Runtime.executionContextCreated";
			public const string ExecutionContextDestroyed = "Runtime.executionContextDestroyed";
			public const string ExecutionContextsCleared = "Runtime.executionContextsCleared";
		}

		public static class Console
		{
			public const string Enable = "Console.enable";
			public const string Disable = "Console.disable";
			public const string ClearMessages = "Console.clearMessages";
			public const string MessageAdded = "Console.messageAdded";
			public const string MessageRepeatCountUpdated = "Console.messageRepeatCountUpdated";
			public const string MessagesCleared = "Console.messagesCleared";
		}

		public static class Network
		{
			public const string Enable = "Network.enable";
			public const string Disable = "Network.disable";
			public const string SetUserAgentOverride = "Network.setUserAgentOverride";
			public const string SetExtraHTTPHeaders = "Network.setExtraHTTPHeaders";
			public const string GetResponseBody = "Network.getResponseBody";
			public const string ReplayXHR = "Network.replayXHR";
			public const string SetMonitoringXHREnabled = "Network.setMonitoringXHREnabled";
			public const string CanClearBrowserCache = "Network.canClearBrowserCache";
			public const string ClearBrowserCache = "Network.clearBrowserCache";
			public const string CanClearBrowserCookies = "Network.canClearBrowserCookies";
			public const string ClearBrowserCookies = "Network.clearBrowserCookies";
			public const string GetCookies = "Network.getCookies";
			public const string DeleteCookie = "Network.deleteCookie";
			public const string CanEmulateNetworkConditions = "Network.canEmulateNetworkConditions";
			public const string EmulateNetworkConditions = "Network.emulateNetworkConditions";
			public const string SetCacheDisabled = "Network.setCacheDisabled";
			public const string SetDataSizeLimitsForTest = "Network.setDataSizeLimitsForTest";
			public const string RequestWillBeSent = "Network.requestWillBeSent";
			public const string RequestServedFromCache = "Network.requestServedFromCache";
			public const string ResponseReceived = "Network.responseReceived";
			public const string DataReceived = "Network.dataReceived";
			public const string LoadingFinished = "Network.loadingFinished";
			public const string LoadingFailed = "Network.loadingFailed";
			public const string WebSocketWillSendHandshakeRequest = "Network.webSocketWillSendHandshakeRequest";
			public const string WebSocketHandshakeResponseReceived = "Network.webSocketHandshakeResponseReceived";
			public const string WebSocketCreated = "Network.webSocketCreated";
			public const string WebSocketClosed = "Network.webSocketClosed";
			public const string WebSocketFrameReceived = "Network.webSocketFrameReceived";
			public const string WebSocketFrameError = "Network.webSocketFrameError";
			public const string WebSocketFrameSent = "Network.webSocketFrameSent";
			public const string EventSourceMessageReceived = "Network.eventSourceMessageReceived";
		}

		public static class Database
		{
			public const string Enable = "Database.enable";
			public const string Disable = "Database.disable";
			public const string GetDatabaseTableNames = "Database.getDatabaseTableNames";
			public const string ExecuteSQL = "Database.executeSQL";
			public const string AddDatabase = "Database.addDatabase";
		}

		public static class IndexedDB
		{
			public const string Enable = "IndexedDB.enable";
			public const string Disable = "IndexedDB.disable";
			public const string RequestDatabaseNames = "IndexedDB.requestDatabaseNames";
			public const string RequestDatabase = "IndexedDB.requestDatabase";
			public const string RequestData = "IndexedDB.requestData";
			public const string ClearObjectStore = "IndexedDB.clearObjectStore";
		}

		public static class CacheStorage
		{
			public const string RequestCacheNames = "CacheStorage.requestCacheNames";
			public const string RequestEntries = "CacheStorage.requestEntries";
			public const string DeleteCache = "CacheStorage.deleteCache";
		}

		public static class DOMStorage
		{
			public const string Enable = "DOMStorage.enable";
			public const string Disable = "DOMStorage.disable";
			public const string GetDOMStorageItems = "DOMStorage.getDOMStorageItems";
			public const string SetDOMStorageItem = "DOMStorage.setDOMStorageItem";
			public const string RemoveDOMStorageItem = "DOMStorage.removeDOMStorageItem";
			public const string DomStorageItemsCleared = "DOMStorage.domStorageItemsCleared";
			public const string DomStorageItemRemoved = "DOMStorage.domStorageItemRemoved";
			public const string DomStorageItemAdded = "DOMStorage.domStorageItemAdded";
			public const string DomStorageItemUpdated = "DOMStorage.domStorageItemUpdated";
		}

		public static class ApplicationCache
		{
			public const string GetFramesWithManifests = "ApplicationCache.getFramesWithManifests";
			public const string Enable = "ApplicationCache.enable";
			public const string GetManifestForFrame = "ApplicationCache.getManifestForFrame";
			public const string GetApplicationCacheForFrame = "ApplicationCache.getApplicationCacheForFrame";
			public const string ApplicationCacheStatusUpdated = "ApplicationCache.applicationCacheStatusUpdated";
			public const string NetworkStateUpdated = "ApplicationCache.networkStateUpdated";
		}

		public static class FileSystem
		{
			public const string Enable = "FileSystem.enable";
			public const string Disable = "FileSystem.disable";
			public const string RequestFileSystemRoot = "FileSystem.requestFileSystemRoot";
			public const string RequestDirectoryContent = "FileSystem.requestDirectoryContent";
			public const string RequestMetadata = "FileSystem.requestMetadata";
			public const string RequestFileContent = "FileSystem.requestFileContent";
			public const string DeleteEntry = "FileSystem.deleteEntry";
		}

		public static class DOM
		{
			public const string Enable = "DOM.enable";
			public const string Disable = "DOM.disable";
			public const string GetDocument = "DOM.getDocument";
			public const string RequestChildNodes = "DOM.requestChildNodes";
			public const string QuerySelector = "DOM.querySelector";
			public const string QuerySelectorAll = "DOM.querySelectorAll";
			public const string SetNodeName = "DOM.setNodeName";
			public const string SetNodeValue = "DOM.setNodeValue";
			public const string RemoveNode = "DOM.removeNode";
			public const string SetAttributeValue = "DOM.setAttributeValue";
			public const string SetAttributesAsText = "DOM.setAttributesAsText";
			public const string RemoveAttribute = "DOM.removeAttribute";
			public const string GetEventListenersForNode = "DOM.getEventListenersForNode";
			public const string GetOuterHTML = "DOM.getOuterHTML";
			public const string SetOuterHTML = "DOM.setOuterHTML";
			public const string PerformSearch = "DOM.performSearch";
			public const string GetSearchResults = "DOM.getSearchResults";
			public const string DiscardSearchResults = "DOM.discardSearchResults";
			public const string RequestNode = "DOM.requestNode";
			public const string SetInspectModeEnabled = "DOM.setInspectModeEnabled";
			public const string HighlightRect = "DOM.highlightRect";
			public const string HighlightQuad = "DOM.highlightQuad";
			public const string HighlightNode = "DOM.highlightNode";
			public const string HideHighlight = "DOM.hideHighlight";
			public const string HighlightFrame = "DOM.highlightFrame";
			public const string PushNodeByPathToFrontend = "DOM.pushNodeByPathToFrontend";
			public const string PushNodesByBackendIdsToFrontend = "DOM.pushNodesByBackendIdsToFrontend";
			public const string SetInspectedNode = "DOM.setInspectedNode";
			public const string ResolveNode = "DOM.resolveNode";
			public const string GetAttributes = "DOM.getAttributes";
			public const string CopyTo = "DOM.copyTo";
			public const string MoveTo = "DOM.moveTo";
			public const string Undo = "DOM.undo";
			public const string Redo = "DOM.redo";
			public const string MarkUndoableState = "DOM.markUndoableState";
			public const string Focus = "DOM.focus";
			public const string SetFileInputFiles = "DOM.setFileInputFiles";
			public const string GetBoxModel = "DOM.getBoxModel";
			public const string GetNodeForLocation = "DOM.getNodeForLocation";
			public const string GetRelayoutBoundary = "DOM.getRelayoutBoundary";
			public const string GetHighlightObjectForTest = "DOM.getHighlightObjectForTest";
			public const string DocumentUpdated = "DOM.documentUpdated";
			public const string InspectNodeRequested = "DOM.inspectNodeRequested";
			public const string SetChildNodes = "DOM.setChildNodes";
			public const string AttributeModified = "DOM.attributeModified";
			public const string AttributeRemoved = "DOM.attributeRemoved";
			public const string InlineStyleInvalidated = "DOM.inlineStyleInvalidated";
			public const string CharacterDataModified = "DOM.characterDataModified";
			public const string ChildNodeCountUpdated = "DOM.childNodeCountUpdated";
			public const string ChildNodeInserted = "DOM.childNodeInserted";
			public const string ChildNodeRemoved = "DOM.childNodeRemoved";
			public const string ShadowRootPushed = "DOM.shadowRootPushed";
			public const string ShadowRootPopped = "DOM.shadowRootPopped";
			public const string PseudoElementAdded = "DOM.pseudoElementAdded";
			public const string PseudoElementRemoved = "DOM.pseudoElementRemoved";
			public const string DistributedNodesUpdated = "DOM.distributedNodesUpdated";
		}

		public static class CSS
		{
			public const string Enable = "CSS.enable";
			public const string Disable = "CSS.disable";
			public const string GetMatchedStylesForNode = "CSS.getMatchedStylesForNode";
			public const string GetInlineStylesForNode = "CSS.getInlineStylesForNode";
			public const string GetComputedStyleForNode = "CSS.getComputedStyleForNode";
			public const string GetPlatformFontsForNode = "CSS.getPlatformFontsForNode";
			public const string GetStyleSheetText = "CSS.getStyleSheetText";
			public const string SetStyleSheetText = "CSS.setStyleSheetText";
			public const string SetPropertyText = "CSS.setPropertyText";
			public const string SetRuleSelector = "CSS.setRuleSelector";
			public const string SetMediaText = "CSS.setMediaText";
			public const string CreateStyleSheet = "CSS.createStyleSheet";
			public const string AddRule = "CSS.addRule";
			public const string ForcePseudoState = "CSS.forcePseudoState";
			public const string GetMediaQueries = "CSS.getMediaQueries";
			public const string MediaQueryResultChanged = "CSS.mediaQueryResultChanged";
			public const string StyleSheetChanged = "CSS.styleSheetChanged";
			public const string StyleSheetAdded = "CSS.styleSheetAdded";
			public const string StyleSheetRemoved = "CSS.styleSheetRemoved";
		}

		public static class Timeline
		{
			public const string Enable = "Timeline.enable";
			public const string Disable = "Timeline.disable";
			public const string Start = "Timeline.start";
			public const string Stop = "Timeline.stop";
			public const string EventRecorded = "Timeline.eventRecorded";
		}

		public static class Debugger
		{
			public const string Enable = "Debugger.enable";
			public const string Disable = "Debugger.disable";
			public const string SetBreakpointsActive = "Debugger.setBreakpointsActive";
			public const string SetSkipAllPauses = "Debugger.setSkipAllPauses";
			public const string SetBreakpointByUrl = "Debugger.setBreakpointByUrl";
			public const string SetBreakpoint = "Debugger.setBreakpoint";
			public const string RemoveBreakpoint = "Debugger.removeBreakpoint";
			public const string ContinueToLocation = "Debugger.continueToLocation";
			public const string StepOver = "Debugger.stepOver";
			public const string StepInto = "Debugger.stepInto";
			public const string StepOut = "Debugger.stepOut";
			public const string Pause = "Debugger.pause";
			public const string Resume = "Debugger.resume";
			public const string StepIntoAsync = "Debugger.stepIntoAsync";
			public const string SearchInContent = "Debugger.searchInContent";
			public const string CanSetScriptSource = "Debugger.canSetScriptSource";
			public const string SetScriptSource = "Debugger.setScriptSource";
			public const string RestartFrame = "Debugger.restartFrame";
			public const string GetScriptSource = "Debugger.getScriptSource";
			public const string GetFunctionDetails = "Debugger.getFunctionDetails";
			public const string GetGeneratorObjectDetails = "Debugger.getGeneratorObjectDetails";
			public const string GetCollectionEntries = "Debugger.getCollectionEntries";
			public const string SetPauseOnExceptions = "Debugger.setPauseOnExceptions";
			public const string EvaluateOnCallFrame = "Debugger.evaluateOnCallFrame";
			public const string CompileScript = "Debugger.compileScript";
			public const string RunScript = "Debugger.runScript";
			public const string SetVariableValue = "Debugger.setVariableValue";
			public const string GetStepInPositions = "Debugger.getStepInPositions";
			public const string GetBacktrace = "Debugger.getBacktrace";
			public const string SkipStackFrames = "Debugger.skipStackFrames";
			public const string SetAsyncCallStackDepth = "Debugger.setAsyncCallStackDepth";
			public const string EnablePromiseTracker = "Debugger.enablePromiseTracker";
			public const string DisablePromiseTracker = "Debugger.disablePromiseTracker";
			public const string GetPromises = "Debugger.getPromises";
			public const string GetPromiseById = "Debugger.getPromiseById";
			public const string FlushAsyncOperationEvents = "Debugger.flushAsyncOperationEvents";
			public const string SetAsyncOperationBreakpoint = "Debugger.setAsyncOperationBreakpoint";
			public const string RemoveAsyncOperationBreakpoint = "Debugger.removeAsyncOperationBreakpoint";
			public const string GlobalObjectCleared = "Debugger.globalObjectCleared";
			public const string ScriptParsed = "Debugger.scriptParsed";
			public const string ScriptFailedToParse = "Debugger.scriptFailedToParse";
			public const string BreakpointResolved = "Debugger.breakpointResolved";
			public const string Paused = "Debugger.paused";
			public const string Resumed = "Debugger.resumed";
			public const string PromiseUpdated = "Debugger.promiseUpdated";
			public const string AsyncOperationStarted = "Debugger.asyncOperationStarted";
			public const string AsyncOperationCompleted = "Debugger.asyncOperationCompleted";
		}

		public static class DOMDebugger
		{
			public const string SetDOMBreakpoint = "DOMDebugger.setDOMBreakpoint";
			public const string RemoveDOMBreakpoint = "DOMDebugger.removeDOMBreakpoint";
			public const string SetEventListenerBreakpoint = "DOMDebugger.setEventListenerBreakpoint";
			public const string RemoveEventListenerBreakpoint = "DOMDebugger.removeEventListenerBreakpoint";
			public const string SetInstrumentationBreakpoint = "DOMDebugger.setInstrumentationBreakpoint";
			public const string RemoveInstrumentationBreakpoint = "DOMDebugger.removeInstrumentationBreakpoint";
			public const string SetXHRBreakpoint = "DOMDebugger.setXHRBreakpoint";
			public const string RemoveXHRBreakpoint = "DOMDebugger.removeXHRBreakpoint";
		}

		public static class Profiler
		{
			public const string Enable = "Profiler.enable";
			public const string Disable = "Profiler.disable";
			public const string SetSamplingInterval = "Profiler.setSamplingInterval";
			public const string Start = "Profiler.start";
			public const string Stop = "Profiler.stop";
			public const string ConsoleProfileStarted = "Profiler.consoleProfileStarted";
			public const string ConsoleProfileFinished = "Profiler.consoleProfileFinished";
		}

		public static class HeapProfiler
		{
			public const string Enable = "HeapProfiler.enable";
			public const string Disable = "HeapProfiler.disable";
			public const string StartTrackingHeapObjects = "HeapProfiler.startTrackingHeapObjects";
			public const string StopTrackingHeapObjects = "HeapProfiler.stopTrackingHeapObjects";
			public const string TakeHeapSnapshot = "HeapProfiler.takeHeapSnapshot";
			public const string CollectGarbage = "HeapProfiler.collectGarbage";
			public const string GetObjectByHeapObjectId = "HeapProfiler.getObjectByHeapObjectId";
			public const string AddInspectedHeapObject = "HeapProfiler.addInspectedHeapObject";
			public const string GetHeapObjectId = "HeapProfiler.getHeapObjectId";
			public const string AddHeapSnapshotChunk = "HeapProfiler.addHeapSnapshotChunk";
			public const string ResetProfiles = "HeapProfiler.resetProfiles";
			public const string ReportHeapSnapshotProgress = "HeapProfiler.reportHeapSnapshotProgress";
			public const string LastSeenObjectId = "HeapProfiler.lastSeenObjectId";
			public const string HeapStatsUpdate = "HeapProfiler.heapStatsUpdate";
		}

		public static class Worker
		{
			public const string Enable = "Worker.enable";
			public const string Disable = "Worker.disable";
			public const string SendMessageToWorker = "Worker.sendMessageToWorker";
			public const string ConnectToWorker = "Worker.connectToWorker";
			public const string DisconnectFromWorker = "Worker.disconnectFromWorker";
			public const string SetAutoconnectToWorkers = "Worker.setAutoconnectToWorkers";
			public const string WorkerCreated = "Worker.workerCreated";
			public const string WorkerTerminated = "Worker.workerTerminated";
			public const string DispatchMessageFromWorker = "Worker.dispatchMessageFromWorker";
		}

		public static class ServiceWorker
		{
			public const string Enable = "ServiceWorker.enable";
			public const string Disable = "ServiceWorker.disable";
			public const string SendMessage = "ServiceWorker.sendMessage";
			public const string Stop = "ServiceWorker.stop";
			public const string Unregister = "ServiceWorker.unregister";
			public const string UpdateRegistration = "ServiceWorker.updateRegistration";
			public const string StartWorker = "ServiceWorker.startWorker";
			public const string StopWorker = "ServiceWorker.stopWorker";
			public const string InspectWorker = "ServiceWorker.inspectWorker";
			public const string SetDebugOnStart = "ServiceWorker.setDebugOnStart";
			public const string DeliverPushMessage = "ServiceWorker.deliverPushMessage";
			public const string WorkerCreated = "ServiceWorker.workerCreated";
			public const string WorkerTerminated = "ServiceWorker.workerTerminated";
			public const string DispatchMessage = "ServiceWorker.dispatchMessage";
			public const string WorkerRegistrationUpdated = "ServiceWorker.workerRegistrationUpdated";
			public const string WorkerVersionUpdated = "ServiceWorker.workerVersionUpdated";
			public const string WorkerErrorReported = "ServiceWorker.workerErrorReported";
			public const string DebugOnStartUpdated = "ServiceWorker.debugOnStartUpdated";
		}

		public static class Canvas
		{
			public const string Enable = "Canvas.enable";
			public const string Disable = "Canvas.disable";
			public const string DropTraceLog = "Canvas.dropTraceLog";
			public const string HasUninstrumentedCanvases = "Canvas.hasUninstrumentedCanvases";
			public const string CaptureFrame = "Canvas.captureFrame";
			public const string StartCapturing = "Canvas.startCapturing";
			public const string StopCapturing = "Canvas.stopCapturing";
			public const string GetTraceLog = "Canvas.getTraceLog";
			public const string ReplayTraceLog = "Canvas.replayTraceLog";
			public const string GetResourceState = "Canvas.getResourceState";
			public const string EvaluateTraceLogCallArgument = "Canvas.evaluateTraceLogCallArgument";
			public const string ContextCreated = "Canvas.contextCreated";
			public const string TraceLogsRemoved = "Canvas.traceLogsRemoved";
		}

		public static class Input
		{
			public const string DispatchKeyEvent = "Input.dispatchKeyEvent";
			public const string DispatchMouseEvent = "Input.dispatchMouseEvent";
			public const string DispatchTouchEvent = "Input.dispatchTouchEvent";
			public const string EmulateTouchFromMouseEvent = "Input.emulateTouchFromMouseEvent";
			public const string SynthesizePinchGesture = "Input.synthesizePinchGesture";
			public const string SynthesizeScrollGesture = "Input.synthesizeScrollGesture";
			public const string SynthesizeTapGesture = "Input.synthesizeTapGesture";
		}

		public static class LayerTree
		{
			public const string Enable = "LayerTree.enable";
			public const string Disable = "LayerTree.disable";
			public const string CompositingReasons = "LayerTree.compositingReasons";
			public const string MakeSnapshot = "LayerTree.makeSnapshot";
			public const string LoadSnapshot = "LayerTree.loadSnapshot";
			public const string ReleaseSnapshot = "LayerTree.releaseSnapshot";
			public const string ProfileSnapshot = "LayerTree.profileSnapshot";
			public const string ReplaySnapshot = "LayerTree.replaySnapshot";
			public const string SnapshotCommandLog = "LayerTree.snapshotCommandLog";
			public const string LayerTreeDidChange = "LayerTree.layerTreeDidChange";
			public const string LayerPainted = "LayerTree.layerPainted";
		}

		public static class DeviceOrientation
		{
			public const string SetDeviceOrientationOverride = "DeviceOrientation.setDeviceOrientationOverride";
			public const string ClearDeviceOrientationOverride = "DeviceOrientation.clearDeviceOrientationOverride";
		}

		public static class Tracing
		{
			public const string Start = "Tracing.start";
			public const string End = "Tracing.end";
			public const string GetCategories = "Tracing.getCategories";
			public const string DataCollected = "Tracing.dataCollected";
			public const string TracingComplete = "Tracing.tracingComplete";
			public const string BufferUsage = "Tracing.bufferUsage";
		}

		public static class Power
		{
			public const string Start = "Power.start";
			public const string End = "Power.end";
			public const string CanProfilePower = "Power.canProfilePower";
			public const string GetAccuracyLevel = "Power.getAccuracyLevel";
			public const string DataAvailable = "Power.dataAvailable";
		}

		public static class Animation
		{
			public const string Enable = "Animation.enable";
			public const string GetAnimationPlayersForNode = "Animation.getAnimationPlayersForNode";
			public const string GetPlaybackRate = "Animation.getPlaybackRate";
			public const string SetPlaybackRate = "Animation.setPlaybackRate";
			public const string SetCurrentTime = "Animation.setCurrentTime";
			public const string SetTiming = "Animation.setTiming";
			public const string AnimationPlayerCreated = "Animation.animationPlayerCreated";
			public const string AnimationPlayerCanceled = "Animation.animationPlayerCanceled";
		}

		public static class Accessibility
		{
			public const string GetAXNode = "Accessibility.getAXNode";
		}

	}
}
