using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.iOS
{
	public static class ProtocolName
	{
		public static class ApplicationCache
		{
			public const string GetFramesWithManifests = "ApplicationCache.getFramesWithManifests";
			public const string Enable = "ApplicationCache.enable";
			public const string GetManifestForFrame = "ApplicationCache.getManifestForFrame";
			public const string GetApplicationCacheForFrame = "ApplicationCache.getApplicationCacheForFrame";
			public const string ApplicationCacheStatusUpdated = "ApplicationCache.applicationCacheStatusUpdated";
			public const string NetworkStateUpdated = "ApplicationCache.networkStateUpdated";
		}

		public static class CSS
		{
			public const string Enable = "CSS.enable";
			public const string Disable = "CSS.disable";
			public const string GetMatchedStylesForNode = "CSS.getMatchedStylesForNode";
			public const string GetInlineStylesForNode = "CSS.getInlineStylesForNode";
			public const string GetComputedStyleForNode = "CSS.getComputedStyleForNode";
			public const string GetAllStyleSheets = "CSS.getAllStyleSheets";
			public const string GetStyleSheet = "CSS.getStyleSheet";
			public const string GetStyleSheetText = "CSS.getStyleSheetText";
			public const string SetStyleSheetText = "CSS.setStyleSheetText";
			public const string SetStyleText = "CSS.setStyleText";
			public const string SetRuleSelector = "CSS.setRuleSelector";
			public const string CreateStyleSheet = "CSS.createStyleSheet";
			public const string AddRule = "CSS.addRule";
			public const string GetSupportedCSSProperties = "CSS.getSupportedCSSProperties";
			public const string GetSupportedSystemFontFamilyNames = "CSS.getSupportedSystemFontFamilyNames";
			public const string ForcePseudoState = "CSS.forcePseudoState";
			public const string GetNamedFlowCollection = "CSS.getNamedFlowCollection";
			public const string MediaQueryResultChanged = "CSS.mediaQueryResultChanged";
			public const string StyleSheetChanged = "CSS.styleSheetChanged";
			public const string StyleSheetAdded = "CSS.styleSheetAdded";
			public const string StyleSheetRemoved = "CSS.styleSheetRemoved";
			public const string NamedFlowCreated = "CSS.namedFlowCreated";
			public const string NamedFlowRemoved = "CSS.namedFlowRemoved";
			public const string RegionOversetChanged = "CSS.regionOversetChanged";
			public const string RegisteredNamedFlowContentElement = "CSS.registeredNamedFlowContentElement";
			public const string UnregisteredNamedFlowContentElement = "CSS.unregisteredNamedFlowContentElement";
		}

		public static class Console
		{
			public const string Enable = "Console.enable";
			public const string Disable = "Console.disable";
			public const string ClearMessages = "Console.clearMessages";
			public const string SetMonitoringXHREnabled = "Console.setMonitoringXHREnabled";
			public const string AddInspectedNode = "Console.addInspectedNode";
			public const string MessageAdded = "Console.messageAdded";
			public const string MessageRepeatCountUpdated = "Console.messageRepeatCountUpdated";
			public const string MessagesCleared = "Console.messagesCleared";
		}

		public static class DOM
		{
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
			public const string GetAccessibilityPropertiesForNode = "DOM.getAccessibilityPropertiesForNode";
			public const string GetOuterHTML = "DOM.getOuterHTML";
			public const string SetOuterHTML = "DOM.setOuterHTML";
			public const string PerformSearch = "DOM.performSearch";
			public const string GetSearchResults = "DOM.getSearchResults";
			public const string DiscardSearchResults = "DOM.discardSearchResults";
			public const string RequestNode = "DOM.requestNode";
			public const string SetInspectModeEnabled = "DOM.setInspectModeEnabled";
			public const string HighlightRect = "DOM.highlightRect";
			public const string HighlightQuad = "DOM.highlightQuad";
			public const string HighlightSelector = "DOM.highlightSelector";
			public const string HighlightNode = "DOM.highlightNode";
			public const string HideHighlight = "DOM.hideHighlight";
			public const string HighlightFrame = "DOM.highlightFrame";
			public const string PushNodeByPathToFrontend = "DOM.pushNodeByPathToFrontend";
			public const string PushNodeByBackendIdToFrontend = "DOM.pushNodeByBackendIdToFrontend";
			public const string ReleaseBackendNodeIds = "DOM.releaseBackendNodeIds";
			public const string ResolveNode = "DOM.resolveNode";
			public const string GetAttributes = "DOM.getAttributes";
			public const string MoveTo = "DOM.moveTo";
			public const string Undo = "DOM.undo";
			public const string Redo = "DOM.redo";
			public const string MarkUndoableState = "DOM.markUndoableState";
			public const string Focus = "DOM.focus";
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

		public static class Database
		{
			public const string Enable = "Database.enable";
			public const string Disable = "Database.disable";
			public const string GetDatabaseTableNames = "Database.getDatabaseTableNames";
			public const string ExecuteSQL = "Database.executeSQL";
			public const string AddDatabase = "Database.addDatabase";
		}

		public static class Debugger
		{
			public const string Enable = "Debugger.enable";
			public const string Disable = "Debugger.disable";
			public const string SetBreakpointsActive = "Debugger.setBreakpointsActive";
			public const string SetBreakpointByUrl = "Debugger.setBreakpointByUrl";
			public const string SetBreakpoint = "Debugger.setBreakpoint";
			public const string RemoveBreakpoint = "Debugger.removeBreakpoint";
			public const string ContinueToLocation = "Debugger.continueToLocation";
			public const string StepOver = "Debugger.stepOver";
			public const string StepInto = "Debugger.stepInto";
			public const string StepOut = "Debugger.stepOut";
			public const string Pause = "Debugger.pause";
			public const string Resume = "Debugger.resume";
			public const string SearchInContent = "Debugger.searchInContent";
			public const string GetScriptSource = "Debugger.getScriptSource";
			public const string GetFunctionDetails = "Debugger.getFunctionDetails";
			public const string SetPauseOnExceptions = "Debugger.setPauseOnExceptions";
			public const string EvaluateOnCallFrame = "Debugger.evaluateOnCallFrame";
			public const string SetOverlayMessage = "Debugger.setOverlayMessage";
			public const string GlobalObjectCleared = "Debugger.globalObjectCleared";
			public const string ScriptParsed = "Debugger.scriptParsed";
			public const string ScriptFailedToParse = "Debugger.scriptFailedToParse";
			public const string BreakpointResolved = "Debugger.breakpointResolved";
			public const string Paused = "Debugger.paused";
			public const string Resumed = "Debugger.resumed";
			public const string DidSampleProbe = "Debugger.didSampleProbe";
			public const string PlayBreakpointActionSound = "Debugger.playBreakpointActionSound";
		}

		public static class GenericTypes
		{
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

		public static class Inspector
		{
			public const string Enable = "Inspector.enable";
			public const string Disable = "Inspector.disable";
			public const string Initialized = "Inspector.initialized";
			public const string EvaluateForTestInFrontend = "Inspector.evaluateForTestInFrontend";
			public const string Inspect = "Inspector.inspect";
			public const string Detached = "Inspector.detached";
			public const string ActivateExtraDomains = "Inspector.activateExtraDomains";
			public const string TargetCrashed = "Inspector.targetCrashed";
		}

		public static class LayerTree
		{
			public const string Enable = "LayerTree.enable";
			public const string Disable = "LayerTree.disable";
			public const string LayersForNode = "LayerTree.layersForNode";
			public const string ReasonsForCompositingLayer = "LayerTree.reasonsForCompositingLayer";
			public const string LayerTreeDidChange = "LayerTree.layerTreeDidChange";
		}

		public static class Network
		{
			public const string Enable = "Network.enable";
			public const string Disable = "Network.disable";
			public const string SetExtraHTTPHeaders = "Network.setExtraHTTPHeaders";
			public const string GetResponseBody = "Network.getResponseBody";
			public const string CanClearBrowserCache = "Network.canClearBrowserCache";
			public const string ClearBrowserCache = "Network.clearBrowserCache";
			public const string CanClearBrowserCookies = "Network.canClearBrowserCookies";
			public const string ClearBrowserCookies = "Network.clearBrowserCookies";
			public const string SetCacheDisabled = "Network.setCacheDisabled";
			public const string LoadResource = "Network.loadResource";
			public const string RequestWillBeSent = "Network.requestWillBeSent";
			public const string RequestServedFromCache = "Network.requestServedFromCache";
			public const string ResponseReceived = "Network.responseReceived";
			public const string DataReceived = "Network.dataReceived";
			public const string LoadingFinished = "Network.loadingFinished";
			public const string LoadingFailed = "Network.loadingFailed";
			public const string RequestServedFromMemoryCache = "Network.requestServedFromMemoryCache";
			public const string WebSocketWillSendHandshakeRequest = "Network.webSocketWillSendHandshakeRequest";
			public const string WebSocketHandshakeResponseReceived = "Network.webSocketHandshakeResponseReceived";
			public const string WebSocketCreated = "Network.webSocketCreated";
			public const string WebSocketClosed = "Network.webSocketClosed";
			public const string WebSocketFrameReceived = "Network.webSocketFrameReceived";
			public const string WebSocketFrameError = "Network.webSocketFrameError";
			public const string WebSocketFrameSent = "Network.webSocketFrameSent";
		}

		public static class OverlayTypes
		{
		}

		public static class Page
		{
			public const string Enable = "Page.enable";
			public const string Disable = "Page.disable";
			public const string AddScriptToEvaluateOnLoad = "Page.addScriptToEvaluateOnLoad";
			public const string RemoveScriptToEvaluateOnLoad = "Page.removeScriptToEvaluateOnLoad";
			public const string Reload = "Page.reload";
			public const string Navigate = "Page.navigate";
			public const string GetCookies = "Page.getCookies";
			public const string DeleteCookie = "Page.deleteCookie";
			public const string GetResourceTree = "Page.getResourceTree";
			public const string GetResourceContent = "Page.getResourceContent";
			public const string SearchInResource = "Page.searchInResource";
			public const string SearchInResources = "Page.searchInResources";
			public const string SetDocumentContent = "Page.setDocumentContent";
			public const string SetShowPaintRects = "Page.setShowPaintRects";
			public const string GetScriptExecutionStatus = "Page.getScriptExecutionStatus";
			public const string SetScriptExecutionDisabled = "Page.setScriptExecutionDisabled";
			public const string SetTouchEmulationEnabled = "Page.setTouchEmulationEnabled";
			public const string SetEmulatedMedia = "Page.setEmulatedMedia";
			public const string GetCompositingBordersVisible = "Page.getCompositingBordersVisible";
			public const string SetCompositingBordersVisible = "Page.setCompositingBordersVisible";
			public const string SnapshotNode = "Page.snapshotNode";
			public const string SnapshotRect = "Page.snapshotRect";
			public const string HandleJavaScriptDialog = "Page.handleJavaScriptDialog";
			public const string Archive = "Page.archive";
			public const string DomContentEventFired = "Page.domContentEventFired";
			public const string LoadEventFired = "Page.loadEventFired";
			public const string FrameNavigated = "Page.frameNavigated";
			public const string FrameDetached = "Page.frameDetached";
			public const string FrameStartedLoading = "Page.frameStartedLoading";
			public const string FrameStoppedLoading = "Page.frameStoppedLoading";
			public const string FrameScheduledNavigation = "Page.frameScheduledNavigation";
			public const string FrameClearedScheduledNavigation = "Page.frameClearedScheduledNavigation";
			public const string JavascriptDialogOpening = "Page.javascriptDialogOpening";
			public const string JavascriptDialogClosed = "Page.javascriptDialogClosed";
			public const string ScriptsEnabled = "Page.scriptsEnabled";
		}

		public static class Runtime
		{
			public const string Parse = "Runtime.parse";
			public const string Evaluate = "Runtime.evaluate";
			public const string CallFunctionOn = "Runtime.callFunctionOn";
			public const string GetProperties = "Runtime.getProperties";
			public const string GetDisplayableProperties = "Runtime.getDisplayableProperties";
			public const string GetCollectionEntries = "Runtime.getCollectionEntries";
			public const string SaveResult = "Runtime.saveResult";
			public const string ReleaseObject = "Runtime.releaseObject";
			public const string ReleaseObjectGroup = "Runtime.releaseObjectGroup";
			public const string Run = "Runtime.run";
			public const string Enable = "Runtime.enable";
			public const string Disable = "Runtime.disable";
			public const string GetRuntimeTypesForVariablesAtOffsets = "Runtime.getRuntimeTypesForVariablesAtOffsets";
			public const string EnableTypeProfiler = "Runtime.enableTypeProfiler";
			public const string DisableTypeProfiler = "Runtime.disableTypeProfiler";
			public const string GetBasicBlocks = "Runtime.getBasicBlocks";
			public const string ExecutionContextCreated = "Runtime.executionContextCreated";
		}

		public static class Timeline
		{
			public const string Start = "Timeline.start";
			public const string Stop = "Timeline.stop";
			public const string EventRecorded = "Timeline.eventRecorded";
			public const string RecordingStarted = "Timeline.recordingStarted";
			public const string RecordingStopped = "Timeline.recordingStopped";
		}

		public static class Worker
		{
			public const string Enable = "Worker.enable";
			public const string Disable = "Worker.disable";
			public const string SendMessageToWorker = "Worker.sendMessageToWorker";
			public const string CanInspectWorkers = "Worker.canInspectWorkers";
			public const string ConnectToWorker = "Worker.connectToWorker";
			public const string DisconnectFromWorker = "Worker.disconnectFromWorker";
			public const string SetAutoconnectToWorkers = "Worker.setAutoconnectToWorkers";
			public const string WorkerCreated = "Worker.workerCreated";
			public const string WorkerTerminated = "Worker.workerTerminated";
			public const string DispatchMessageFromWorker = "Worker.dispatchMessageFromWorker";
			public const string DisconnectedFromWorker = "Worker.disconnectedFromWorker";
		}

	}
}
