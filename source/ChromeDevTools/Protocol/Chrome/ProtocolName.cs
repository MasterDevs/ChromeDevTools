using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome
{
	public static class ProtocolName
	{
		public static class Schema
		{
			public const string GetDomains = "Schema.getDomains";
		}

		public static class Runtime
		{
			public const string Evaluate = "Runtime.evaluate";
			public const string AwaitPromise = "Runtime.awaitPromise";
			public const string CallFunctionOn = "Runtime.callFunctionOn";
			public const string GetProperties = "Runtime.getProperties";
			public const string ReleaseObject = "Runtime.releaseObject";
			public const string ReleaseObjectGroup = "Runtime.releaseObjectGroup";
			public const string RunIfWaitingForDebugger = "Runtime.runIfWaitingForDebugger";
			public const string Enable = "Runtime.enable";
			public const string Disable = "Runtime.disable";
			public const string DiscardConsoleEntries = "Runtime.discardConsoleEntries";
			public const string SetCustomObjectFormatterEnabled = "Runtime.setCustomObjectFormatterEnabled";
			public const string CompileScript = "Runtime.compileScript";
			public const string RunScript = "Runtime.runScript";
			public const string QueryObjects = "Runtime.queryObjects";
			public const string ExecutionContextCreated = "Runtime.executionContextCreated";
			public const string ExecutionContextDestroyed = "Runtime.executionContextDestroyed";
			public const string ExecutionContextsCleared = "Runtime.executionContextsCleared";
			public const string ExceptionThrown = "Runtime.exceptionThrown";
			public const string ExceptionRevoked = "Runtime.exceptionRevoked";
			public const string ConsoleAPICalled = "Runtime.consoleAPICalled";
			public const string InspectRequested = "Runtime.inspectRequested";
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
			public const string GetPossibleBreakpoints = "Debugger.getPossibleBreakpoints";
			public const string ContinueToLocation = "Debugger.continueToLocation";
			public const string StepOver = "Debugger.stepOver";
			public const string StepInto = "Debugger.stepInto";
			public const string StepOut = "Debugger.stepOut";
			public const string Pause = "Debugger.pause";
			public const string ScheduleStepIntoAsync = "Debugger.scheduleStepIntoAsync";
			public const string Resume = "Debugger.resume";
			public const string SearchInContent = "Debugger.searchInContent";
			public const string SetScriptSource = "Debugger.setScriptSource";
			public const string RestartFrame = "Debugger.restartFrame";
			public const string GetScriptSource = "Debugger.getScriptSource";
			public const string SetPauseOnExceptions = "Debugger.setPauseOnExceptions";
			public const string EvaluateOnCallFrame = "Debugger.evaluateOnCallFrame";
			public const string SetVariableValue = "Debugger.setVariableValue";
			public const string SetAsyncCallStackDepth = "Debugger.setAsyncCallStackDepth";
			public const string SetBlackboxPatterns = "Debugger.setBlackboxPatterns";
			public const string SetBlackboxedRanges = "Debugger.setBlackboxedRanges";
			public const string ScriptParsed = "Debugger.scriptParsed";
			public const string ScriptFailedToParse = "Debugger.scriptFailedToParse";
			public const string BreakpointResolved = "Debugger.breakpointResolved";
			public const string Paused = "Debugger.paused";
			public const string Resumed = "Debugger.resumed";
		}

		public static class Console
		{
			public const string Enable = "Console.enable";
			public const string Disable = "Console.disable";
			public const string ClearMessages = "Console.clearMessages";
			public const string MessageAdded = "Console.messageAdded";
		}

		public static class Profiler
		{
			public const string Enable = "Profiler.enable";
			public const string Disable = "Profiler.disable";
			public const string SetSamplingInterval = "Profiler.setSamplingInterval";
			public const string Start = "Profiler.start";
			public const string Stop = "Profiler.stop";
			public const string StartPreciseCoverage = "Profiler.startPreciseCoverage";
			public const string StopPreciseCoverage = "Profiler.stopPreciseCoverage";
			public const string TakePreciseCoverage = "Profiler.takePreciseCoverage";
			public const string GetBestEffortCoverage = "Profiler.getBestEffortCoverage";
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
			public const string StartSampling = "HeapProfiler.startSampling";
			public const string StopSampling = "HeapProfiler.stopSampling";
			public const string AddHeapSnapshotChunk = "HeapProfiler.addHeapSnapshotChunk";
			public const string ResetProfiles = "HeapProfiler.resetProfiles";
			public const string ReportHeapSnapshotProgress = "HeapProfiler.reportHeapSnapshotProgress";
			public const string LastSeenObjectId = "HeapProfiler.lastSeenObjectId";
			public const string HeapStatsUpdate = "HeapProfiler.heapStatsUpdate";
		}

		public static class Inspector
		{
			public const string Enable = "Inspector.enable";
			public const string Disable = "Inspector.disable";
			public const string Detached = "Inspector.detached";
			public const string TargetCrashed = "Inspector.targetCrashed";
		}

		public static class Memory
		{
			public const string GetDOMCounters = "Memory.getDOMCounters";
			public const string PrepareForLeakDetection = "Memory.prepareForLeakDetection";
			public const string SetPressureNotificationsSuppressed = "Memory.setPressureNotificationsSuppressed";
			public const string SimulatePressureNotification = "Memory.simulatePressureNotification";
		}

		public static class Performance
		{
			public const string Enable = "Performance.enable";
			public const string Disable = "Performance.disable";
			public const string GetMetrics = "Performance.getMetrics";
			public const string Metrics = "Performance.metrics";
		}

		public static class Page
		{
			public const string Enable = "Page.enable";
			public const string Disable = "Page.disable";
			public const string AddScriptToEvaluateOnLoad = "Page.addScriptToEvaluateOnLoad";
			public const string RemoveScriptToEvaluateOnLoad = "Page.removeScriptToEvaluateOnLoad";
			public const string AddScriptToEvaluateOnNewDocument = "Page.addScriptToEvaluateOnNewDocument";
			public const string RemoveScriptToEvaluateOnNewDocument = "Page.removeScriptToEvaluateOnNewDocument";
			public const string SetAutoAttachToCreatedPages = "Page.setAutoAttachToCreatedPages";
			public const string Reload = "Page.reload";
			public const string SetAdBlockingEnabled = "Page.setAdBlockingEnabled";
			public const string Navigate = "Page.navigate";
			public const string StopLoading = "Page.stopLoading";
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
			public const string PrintToPDF = "Page.printToPDF";
			public const string StartScreencast = "Page.startScreencast";
			public const string StopScreencast = "Page.stopScreencast";
			public const string ScreencastFrameAck = "Page.screencastFrameAck";
			public const string HandleJavaScriptDialog = "Page.handleJavaScriptDialog";
			public const string GetAppManifest = "Page.getAppManifest";
			public const string RequestAppBanner = "Page.requestAppBanner";
			public const string GetLayoutMetrics = "Page.getLayoutMetrics";
			public const string CreateIsolatedWorld = "Page.createIsolatedWorld";
			public const string BringToFront = "Page.bringToFront";
			public const string SetDownloadBehavior = "Page.setDownloadBehavior";
			public const string DomContentEventFired = "Page.domContentEventFired";
			public const string LoadEventFired = "Page.loadEventFired";
			public const string LifecycleEvent = "Page.lifecycleEvent";
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
			public const string InterstitialShown = "Page.interstitialShown";
			public const string InterstitialHidden = "Page.interstitialHidden";
		}

		public static class Overlay
		{
			public const string Enable = "Overlay.enable";
			public const string Disable = "Overlay.disable";
			public const string SetShowPaintRects = "Overlay.setShowPaintRects";
			public const string SetShowDebugBorders = "Overlay.setShowDebugBorders";
			public const string SetShowFPSCounter = "Overlay.setShowFPSCounter";
			public const string SetShowScrollBottleneckRects = "Overlay.setShowScrollBottleneckRects";
			public const string SetShowViewportSizeOnResize = "Overlay.setShowViewportSizeOnResize";
			public const string SetPausedInDebuggerMessage = "Overlay.setPausedInDebuggerMessage";
			public const string SetSuspended = "Overlay.setSuspended";
			public const string SetInspectMode = "Overlay.setInspectMode";
			public const string HighlightRect = "Overlay.highlightRect";
			public const string HighlightQuad = "Overlay.highlightQuad";
			public const string HighlightNode = "Overlay.highlightNode";
			public const string HighlightFrame = "Overlay.highlightFrame";
			public const string HideHighlight = "Overlay.hideHighlight";
			public const string GetHighlightObjectForTest = "Overlay.getHighlightObjectForTest";
			public const string NodeHighlightRequested = "Overlay.nodeHighlightRequested";
			public const string InspectNodeRequested = "Overlay.inspectNodeRequested";
			public const string ScreenshotRequested = "Overlay.screenshotRequested";
		}

		public static class Emulation
		{
			public const string SetDeviceMetricsOverride = "Emulation.setDeviceMetricsOverride";
			public const string ClearDeviceMetricsOverride = "Emulation.clearDeviceMetricsOverride";
			public const string ResetPageScaleFactor = "Emulation.resetPageScaleFactor";
			public const string SetPageScaleFactor = "Emulation.setPageScaleFactor";
			public const string SetVisibleSize = "Emulation.setVisibleSize";
			public const string SetScriptExecutionDisabled = "Emulation.setScriptExecutionDisabled";
			public const string SetGeolocationOverride = "Emulation.setGeolocationOverride";
			public const string ClearGeolocationOverride = "Emulation.clearGeolocationOverride";
			public const string SetTouchEmulationEnabled = "Emulation.setTouchEmulationEnabled";
			public const string SetEmitTouchEventsForMouse = "Emulation.setEmitTouchEventsForMouse";
			public const string SetEmulatedMedia = "Emulation.setEmulatedMedia";
			public const string SetCPUThrottlingRate = "Emulation.setCPUThrottlingRate";
			public const string CanEmulate = "Emulation.canEmulate";
			public const string SetVirtualTimePolicy = "Emulation.setVirtualTimePolicy";
			public const string SetDefaultBackgroundColorOverride = "Emulation.setDefaultBackgroundColorOverride";
			public const string VirtualTimeBudgetExpired = "Emulation.virtualTimeBudgetExpired";
			public const string VirtualTimePaused = "Emulation.virtualTimePaused";
		}

		public static class Security
		{
			public const string Enable = "Security.enable";
			public const string Disable = "Security.disable";
			public const string HandleCertificateError = "Security.handleCertificateError";
			public const string SetOverrideCertificateErrors = "Security.setOverrideCertificateErrors";
			public const string SecurityStateChanged = "Security.securityStateChanged";
			public const string CertificateError = "Security.certificateError";
		}

		public static class Audits
		{
			public const string GetEncodedResponse = "Audits.getEncodedResponse";
		}

		public static class Network
		{
			public const string Enable = "Network.enable";
			public const string Disable = "Network.disable";
			public const string SetUserAgentOverride = "Network.setUserAgentOverride";
			public const string SetExtraHTTPHeaders = "Network.setExtraHTTPHeaders";
			public const string GetResponseBody = "Network.getResponseBody";
			public const string SetBlockedURLs = "Network.setBlockedURLs";
			public const string ReplayXHR = "Network.replayXHR";
			public const string CanClearBrowserCache = "Network.canClearBrowserCache";
			public const string ClearBrowserCache = "Network.clearBrowserCache";
			public const string CanClearBrowserCookies = "Network.canClearBrowserCookies";
			public const string ClearBrowserCookies = "Network.clearBrowserCookies";
			public const string GetCookies = "Network.getCookies";
			public const string GetAllCookies = "Network.getAllCookies";
			public const string DeleteCookies = "Network.deleteCookies";
			public const string SetCookie = "Network.setCookie";
			public const string SetCookies = "Network.setCookies";
			public const string CanEmulateNetworkConditions = "Network.canEmulateNetworkConditions";
			public const string EmulateNetworkConditions = "Network.emulateNetworkConditions";
			public const string SetCacheDisabled = "Network.setCacheDisabled";
			public const string SetBypassServiceWorker = "Network.setBypassServiceWorker";
			public const string SetDataSizeLimitsForTest = "Network.setDataSizeLimitsForTest";
			public const string GetCertificate = "Network.getCertificate";
			public const string SetRequestInterceptionEnabled = "Network.setRequestInterceptionEnabled";
			public const string ContinueInterceptedRequest = "Network.continueInterceptedRequest";
			public const string ResourceChangedPriority = "Network.resourceChangedPriority";
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
			public const string RequestIntercepted = "Network.requestIntercepted";
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
			public const string DeleteDatabase = "IndexedDB.deleteDatabase";
		}

		public static class CacheStorage
		{
			public const string RequestCacheNames = "CacheStorage.requestCacheNames";
			public const string RequestEntries = "CacheStorage.requestEntries";
			public const string DeleteCache = "CacheStorage.deleteCache";
			public const string DeleteEntry = "CacheStorage.deleteEntry";
			public const string RequestCachedResponse = "CacheStorage.requestCachedResponse";
		}

		public static class DOMStorage
		{
			public const string Enable = "DOMStorage.enable";
			public const string Disable = "DOMStorage.disable";
			public const string Clear = "DOMStorage.clear";
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

		public static class DOM
		{
			public const string Enable = "DOM.enable";
			public const string Disable = "DOM.disable";
			public const string GetDocument = "DOM.getDocument";
			public const string GetFlattenedDocument = "DOM.getFlattenedDocument";
			public const string CollectClassNamesFromSubtree = "DOM.collectClassNamesFromSubtree";
			public const string RequestChildNodes = "DOM.requestChildNodes";
			public const string QuerySelector = "DOM.querySelector";
			public const string QuerySelectorAll = "DOM.querySelectorAll";
			public const string SetNodeName = "DOM.setNodeName";
			public const string SetNodeValue = "DOM.setNodeValue";
			public const string RemoveNode = "DOM.removeNode";
			public const string SetAttributeValue = "DOM.setAttributeValue";
			public const string SetAttributesAsText = "DOM.setAttributesAsText";
			public const string RemoveAttribute = "DOM.removeAttribute";
			public const string GetOuterHTML = "DOM.getOuterHTML";
			public const string SetOuterHTML = "DOM.setOuterHTML";
			public const string PerformSearch = "DOM.performSearch";
			public const string GetSearchResults = "DOM.getSearchResults";
			public const string DiscardSearchResults = "DOM.discardSearchResults";
			public const string RequestNode = "DOM.requestNode";
			public const string HighlightRect = "DOM.highlightRect";
			public const string HighlightNode = "DOM.highlightNode";
			public const string HideHighlight = "DOM.hideHighlight";
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
			public const string DescribeNode = "DOM.describeNode";
			public const string DocumentUpdated = "DOM.documentUpdated";
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
			public const string CollectClassNames = "CSS.collectClassNames";
			public const string SetStyleSheetText = "CSS.setStyleSheetText";
			public const string SetRuleSelector = "CSS.setRuleSelector";
			public const string SetKeyframeKey = "CSS.setKeyframeKey";
			public const string SetStyleTexts = "CSS.setStyleTexts";
			public const string SetMediaText = "CSS.setMediaText";
			public const string CreateStyleSheet = "CSS.createStyleSheet";
			public const string AddRule = "CSS.addRule";
			public const string ForcePseudoState = "CSS.forcePseudoState";
			public const string GetMediaQueries = "CSS.getMediaQueries";
			public const string SetEffectivePropertyValueForNode = "CSS.setEffectivePropertyValueForNode";
			public const string GetBackgroundColors = "CSS.getBackgroundColors";
			public const string StartRuleUsageTracking = "CSS.startRuleUsageTracking";
			public const string TakeCoverageDelta = "CSS.takeCoverageDelta";
			public const string StopRuleUsageTracking = "CSS.stopRuleUsageTracking";
			public const string MediaQueryResultChanged = "CSS.mediaQueryResultChanged";
			public const string FontsUpdated = "CSS.fontsUpdated";
			public const string StyleSheetChanged = "CSS.styleSheetChanged";
			public const string StyleSheetAdded = "CSS.styleSheetAdded";
			public const string StyleSheetRemoved = "CSS.styleSheetRemoved";
		}

		public static class DOMSnapshot
		{
			public const string GetSnapshot = "DOMSnapshot.getSnapshot";
		}

		public static class IO
		{
			public const string Read = "IO.read";
			public const string Close = "IO.close";
			public const string ResolveBlob = "IO.resolveBlob";
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
			public const string GetEventListeners = "DOMDebugger.getEventListeners";
		}

		public static class Target
		{
			public const string SetDiscoverTargets = "Target.setDiscoverTargets";
			public const string SetAutoAttach = "Target.setAutoAttach";
			public const string SetAttachToFrames = "Target.setAttachToFrames";
			public const string SetRemoteLocations = "Target.setRemoteLocations";
			public const string SendMessageToTarget = "Target.sendMessageToTarget";
			public const string GetTargetInfo = "Target.getTargetInfo";
			public const string ActivateTarget = "Target.activateTarget";
			public const string CloseTarget = "Target.closeTarget";
			public const string AttachToTarget = "Target.attachToTarget";
			public const string DetachFromTarget = "Target.detachFromTarget";
			public const string CreateBrowserContext = "Target.createBrowserContext";
			public const string DisposeBrowserContext = "Target.disposeBrowserContext";
			public const string CreateTarget = "Target.createTarget";
			public const string GetTargets = "Target.getTargets";
			public const string TargetCreated = "Target.targetCreated";
			public const string TargetInfoChanged = "Target.targetInfoChanged";
			public const string TargetDestroyed = "Target.targetDestroyed";
			public const string AttachedToTarget = "Target.attachedToTarget";
			public const string DetachedFromTarget = "Target.detachedFromTarget";
			public const string ReceivedMessageFromTarget = "Target.receivedMessageFromTarget";
		}

		public static class ServiceWorker
		{
			public const string Enable = "ServiceWorker.enable";
			public const string Disable = "ServiceWorker.disable";
			public const string Unregister = "ServiceWorker.unregister";
			public const string UpdateRegistration = "ServiceWorker.updateRegistration";
			public const string StartWorker = "ServiceWorker.startWorker";
			public const string SkipWaiting = "ServiceWorker.skipWaiting";
			public const string StopWorker = "ServiceWorker.stopWorker";
			public const string InspectWorker = "ServiceWorker.inspectWorker";
			public const string SetForceUpdateOnPageLoad = "ServiceWorker.setForceUpdateOnPageLoad";
			public const string DeliverPushMessage = "ServiceWorker.deliverPushMessage";
			public const string DispatchSyncEvent = "ServiceWorker.dispatchSyncEvent";
			public const string WorkerRegistrationUpdated = "ServiceWorker.workerRegistrationUpdated";
			public const string WorkerVersionUpdated = "ServiceWorker.workerVersionUpdated";
			public const string WorkerErrorReported = "ServiceWorker.workerErrorReported";
		}

		public static class Input
		{
			public const string SetIgnoreInputEvents = "Input.setIgnoreInputEvents";
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
			public const string RequestMemoryDump = "Tracing.requestMemoryDump";
			public const string RecordClockSyncMarker = "Tracing.recordClockSyncMarker";
			public const string DataCollected = "Tracing.dataCollected";
			public const string TracingComplete = "Tracing.tracingComplete";
			public const string BufferUsage = "Tracing.bufferUsage";
		}

		public static class Animation
		{
			public const string Enable = "Animation.enable";
			public const string Disable = "Animation.disable";
			public const string GetPlaybackRate = "Animation.getPlaybackRate";
			public const string SetPlaybackRate = "Animation.setPlaybackRate";
			public const string GetCurrentTime = "Animation.getCurrentTime";
			public const string SetPaused = "Animation.setPaused";
			public const string SetTiming = "Animation.setTiming";
			public const string SeekAnimations = "Animation.seekAnimations";
			public const string ReleaseAnimations = "Animation.releaseAnimations";
			public const string ResolveAnimation = "Animation.resolveAnimation";
			public const string AnimationCreated = "Animation.animationCreated";
			public const string AnimationStarted = "Animation.animationStarted";
			public const string AnimationCanceled = "Animation.animationCanceled";
		}

		public static class Accessibility
		{
			public const string GetPartialAXTree = "Accessibility.getPartialAXTree";
		}

		public static class Storage
		{
			public const string ClearDataForOrigin = "Storage.clearDataForOrigin";
			public const string GetUsageAndQuota = "Storage.getUsageAndQuota";
			public const string TrackCacheStorageForOrigin = "Storage.trackCacheStorageForOrigin";
			public const string UntrackCacheStorageForOrigin = "Storage.untrackCacheStorageForOrigin";
			public const string CacheStorageListUpdated = "Storage.cacheStorageListUpdated";
			public const string CacheStorageContentUpdated = "Storage.cacheStorageContentUpdated";
		}

		public static class Log
		{
			public const string Enable = "Log.enable";
			public const string Disable = "Log.disable";
			public const string Clear = "Log.clear";
			public const string StartViolationsReport = "Log.startViolationsReport";
			public const string StopViolationsReport = "Log.stopViolationsReport";
			public const string EntryAdded = "Log.entryAdded";
		}

		public static class SystemInfo
		{
			public const string GetInfo = "SystemInfo.getInfo";
		}

		public static class Tethering
		{
			public const string Bind = "Tethering.bind";
			public const string Unbind = "Tethering.unbind";
			public const string Accepted = "Tethering.accepted";
		}

		public static class Browser
		{
			public const string GetWindowForTarget = "Browser.getWindowForTarget";
			public const string GetVersion = "Browser.getVersion";
			public const string SetWindowBounds = "Browser.setWindowBounds";
			public const string GetWindowBounds = "Browser.getWindowBounds";
		}

	}
}
