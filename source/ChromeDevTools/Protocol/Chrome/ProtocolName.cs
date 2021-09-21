using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome
{
	public static class ProtocolName
	{
		public static class Console
		{
			public const string ClearMessages = "Console.clearMessages";
			public const string Disable = "Console.disable";
			public const string Enable = "Console.enable";
			public const string MessageAdded = "Console.messageAdded";
		}

		public static class Debugger
		{
			public const string ContinueToLocation = "Debugger.continueToLocation";
			public const string Disable = "Debugger.disable";
			public const string Enable = "Debugger.enable";
			public const string EvaluateOnCallFrame = "Debugger.evaluateOnCallFrame";
			public const string GetPossibleBreakpoints = "Debugger.getPossibleBreakpoints";
			public const string GetScriptSource = "Debugger.getScriptSource";
			public const string GetWasmBytecode = "Debugger.getWasmBytecode";
			public const string GetStackTrace = "Debugger.getStackTrace";
			public const string Pause = "Debugger.pause";
			public const string PauseOnAsyncCall = "Debugger.pauseOnAsyncCall";
			public const string RemoveBreakpoint = "Debugger.removeBreakpoint";
			public const string RestartFrame = "Debugger.restartFrame";
			public const string Resume = "Debugger.resume";
			public const string SearchInContent = "Debugger.searchInContent";
			public const string SetAsyncCallStackDepth = "Debugger.setAsyncCallStackDepth";
			public const string SetBlackboxPatterns = "Debugger.setBlackboxPatterns";
			public const string SetBlackboxedRanges = "Debugger.setBlackboxedRanges";
			public const string SetBreakpoint = "Debugger.setBreakpoint";
			public const string SetInstrumentationBreakpoint = "Debugger.setInstrumentationBreakpoint";
			public const string SetBreakpointByUrl = "Debugger.setBreakpointByUrl";
			public const string SetBreakpointOnFunctionCall = "Debugger.setBreakpointOnFunctionCall";
			public const string SetBreakpointsActive = "Debugger.setBreakpointsActive";
			public const string SetPauseOnExceptions = "Debugger.setPauseOnExceptions";
			public const string SetReturnValue = "Debugger.setReturnValue";
			public const string SetScriptSource = "Debugger.setScriptSource";
			public const string SetSkipAllPauses = "Debugger.setSkipAllPauses";
			public const string SetVariableValue = "Debugger.setVariableValue";
			public const string StepInto = "Debugger.stepInto";
			public const string StepOut = "Debugger.stepOut";
			public const string StepOver = "Debugger.stepOver";
			public const string BreakpointResolved = "Debugger.breakpointResolved";
			public const string Paused = "Debugger.paused";
			public const string Resumed = "Debugger.resumed";
			public const string ScriptFailedToParse = "Debugger.scriptFailedToParse";
			public const string ScriptParsed = "Debugger.scriptParsed";
		}

		public static class HeapProfiler
		{
			public const string AddInspectedHeapObject = "HeapProfiler.addInspectedHeapObject";
			public const string CollectGarbage = "HeapProfiler.collectGarbage";
			public const string Disable = "HeapProfiler.disable";
			public const string Enable = "HeapProfiler.enable";
			public const string GetHeapObjectId = "HeapProfiler.getHeapObjectId";
			public const string GetObjectByHeapObjectId = "HeapProfiler.getObjectByHeapObjectId";
			public const string GetSamplingProfile = "HeapProfiler.getSamplingProfile";
			public const string StartSampling = "HeapProfiler.startSampling";
			public const string StartTrackingHeapObjects = "HeapProfiler.startTrackingHeapObjects";
			public const string StopSampling = "HeapProfiler.stopSampling";
			public const string StopTrackingHeapObjects = "HeapProfiler.stopTrackingHeapObjects";
			public const string TakeHeapSnapshot = "HeapProfiler.takeHeapSnapshot";
			public const string AddHeapSnapshotChunk = "HeapProfiler.addHeapSnapshotChunk";
			public const string HeapStatsUpdate = "HeapProfiler.heapStatsUpdate";
			public const string LastSeenObjectId = "HeapProfiler.lastSeenObjectId";
			public const string ReportHeapSnapshotProgress = "HeapProfiler.reportHeapSnapshotProgress";
			public const string ResetProfiles = "HeapProfiler.resetProfiles";
		}

		public static class Profiler
		{
			public const string Disable = "Profiler.disable";
			public const string Enable = "Profiler.enable";
			public const string GetBestEffortCoverage = "Profiler.getBestEffortCoverage";
			public const string SetSamplingInterval = "Profiler.setSamplingInterval";
			public const string Start = "Profiler.start";
			public const string StartPreciseCoverage = "Profiler.startPreciseCoverage";
			public const string StartTypeProfile = "Profiler.startTypeProfile";
			public const string Stop = "Profiler.stop";
			public const string StopPreciseCoverage = "Profiler.stopPreciseCoverage";
			public const string StopTypeProfile = "Profiler.stopTypeProfile";
			public const string TakePreciseCoverage = "Profiler.takePreciseCoverage";
			public const string TakeTypeProfile = "Profiler.takeTypeProfile";
			public const string EnableCounters = "Profiler.enableCounters";
			public const string DisableCounters = "Profiler.disableCounters";
			public const string GetCounters = "Profiler.getCounters";
			public const string EnableRuntimeCallStats = "Profiler.enableRuntimeCallStats";
			public const string DisableRuntimeCallStats = "Profiler.disableRuntimeCallStats";
			public const string GetRuntimeCallStats = "Profiler.getRuntimeCallStats";
			public const string ConsoleProfileFinished = "Profiler.consoleProfileFinished";
			public const string ConsoleProfileStarted = "Profiler.consoleProfileStarted";
			public const string PreciseCoverageDeltaUpdate = "Profiler.preciseCoverageDeltaUpdate";
		}

		public static class Runtime
		{
			public const string AwaitPromise = "Runtime.awaitPromise";
			public const string CallFunctionOn = "Runtime.callFunctionOn";
			public const string CompileScript = "Runtime.compileScript";
			public const string Disable = "Runtime.disable";
			public const string DiscardConsoleEntries = "Runtime.discardConsoleEntries";
			public const string Enable = "Runtime.enable";
			public const string Evaluate = "Runtime.evaluate";
			public const string GetIsolateId = "Runtime.getIsolateId";
			public const string GetHeapUsage = "Runtime.getHeapUsage";
			public const string GetProperties = "Runtime.getProperties";
			public const string GlobalLexicalScopeNames = "Runtime.globalLexicalScopeNames";
			public const string QueryObjects = "Runtime.queryObjects";
			public const string ReleaseObject = "Runtime.releaseObject";
			public const string ReleaseObjectGroup = "Runtime.releaseObjectGroup";
			public const string RunIfWaitingForDebugger = "Runtime.runIfWaitingForDebugger";
			public const string RunScript = "Runtime.runScript";
			public const string SetAsyncCallStackDepth = "Runtime.setAsyncCallStackDepth";
			public const string SetCustomObjectFormatterEnabled = "Runtime.setCustomObjectFormatterEnabled";
			public const string SetMaxCallStackSizeToCapture = "Runtime.setMaxCallStackSizeToCapture";
			public const string TerminateExecution = "Runtime.terminateExecution";
			public const string AddBinding = "Runtime.addBinding";
			public const string RemoveBinding = "Runtime.removeBinding";
			public const string BindingCalled = "Runtime.bindingCalled";
			public const string ConsoleAPICalled = "Runtime.consoleAPICalled";
			public const string ExceptionRevoked = "Runtime.exceptionRevoked";
			public const string ExceptionThrown = "Runtime.exceptionThrown";
			public const string ExecutionContextCreated = "Runtime.executionContextCreated";
			public const string ExecutionContextDestroyed = "Runtime.executionContextDestroyed";
			public const string ExecutionContextsCleared = "Runtime.executionContextsCleared";
			public const string InspectRequested = "Runtime.inspectRequested";
		}

		public static class Schema
		{
			public const string GetDomains = "Schema.getDomains";
		}

		public static class Accessibility
		{
			public const string Disable = "Accessibility.disable";
			public const string Enable = "Accessibility.enable";
			public const string GetPartialAXTree = "Accessibility.getPartialAXTree";
			public const string GetFullAXTree = "Accessibility.getFullAXTree";
			public const string GetChildAXNodes = "Accessibility.getChildAXNodes";
			public const string QueryAXTree = "Accessibility.queryAXTree";
		}

		public static class Animation
		{
			public const string Disable = "Animation.disable";
			public const string Enable = "Animation.enable";
			public const string GetCurrentTime = "Animation.getCurrentTime";
			public const string GetPlaybackRate = "Animation.getPlaybackRate";
			public const string ReleaseAnimations = "Animation.releaseAnimations";
			public const string ResolveAnimation = "Animation.resolveAnimation";
			public const string SeekAnimations = "Animation.seekAnimations";
			public const string SetPaused = "Animation.setPaused";
			public const string SetPlaybackRate = "Animation.setPlaybackRate";
			public const string SetTiming = "Animation.setTiming";
			public const string AnimationCanceled = "Animation.animationCanceled";
			public const string AnimationCreated = "Animation.animationCreated";
			public const string AnimationStarted = "Animation.animationStarted";
		}

		public static class ApplicationCache
		{
			public const string Enable = "ApplicationCache.enable";
			public const string GetApplicationCacheForFrame = "ApplicationCache.getApplicationCacheForFrame";
			public const string GetFramesWithManifests = "ApplicationCache.getFramesWithManifests";
			public const string GetManifestForFrame = "ApplicationCache.getManifestForFrame";
			public const string ApplicationCacheStatusUpdated = "ApplicationCache.applicationCacheStatusUpdated";
			public const string NetworkStateUpdated = "ApplicationCache.networkStateUpdated";
		}

		public static class Audits
		{
			public const string GetEncodedResponse = "Audits.getEncodedResponse";
			public const string Disable = "Audits.disable";
			public const string Enable = "Audits.enable";
			public const string CheckContrast = "Audits.checkContrast";
			public const string IssueAdded = "Audits.issueAdded";
		}

		public static class BackgroundService
		{
			public const string StartObserving = "BackgroundService.startObserving";
			public const string StopObserving = "BackgroundService.stopObserving";
			public const string SetRecording = "BackgroundService.setRecording";
			public const string ClearEvents = "BackgroundService.clearEvents";
			public const string RecordingStateChanged = "BackgroundService.recordingStateChanged";
			public const string BackgroundServiceEventReceived = "BackgroundService.backgroundServiceEventReceived";
		}

		public static class Browser
		{
			public const string SetPermission = "Browser.setPermission";
			public const string GrantPermissions = "Browser.grantPermissions";
			public const string ResetPermissions = "Browser.resetPermissions";
			public const string SetDownloadBehavior = "Browser.setDownloadBehavior";
			public const string CancelDownload = "Browser.cancelDownload";
			public const string Close = "Browser.close";
			public const string Crash = "Browser.crash";
			public const string CrashGpuProcess = "Browser.crashGpuProcess";
			public const string GetVersion = "Browser.getVersion";
			public const string GetBrowserCommandLine = "Browser.getBrowserCommandLine";
			public const string GetHistograms = "Browser.getHistograms";
			public const string GetHistogram = "Browser.getHistogram";
			public const string GetWindowBounds = "Browser.getWindowBounds";
			public const string GetWindowForTarget = "Browser.getWindowForTarget";
			public const string SetWindowBounds = "Browser.setWindowBounds";
			public const string SetDockTile = "Browser.setDockTile";
			public const string ExecuteBrowserCommand = "Browser.executeBrowserCommand";
			public const string DownloadWillBegin = "Browser.downloadWillBegin";
			public const string DownloadProgress = "Browser.downloadProgress";
		}

		public static class CSS
		{
			public const string AddRule = "CSS.addRule";
			public const string CollectClassNames = "CSS.collectClassNames";
			public const string CreateStyleSheet = "CSS.createStyleSheet";
			public const string Disable = "CSS.disable";
			public const string Enable = "CSS.enable";
			public const string ForcePseudoState = "CSS.forcePseudoState";
			public const string GetBackgroundColors = "CSS.getBackgroundColors";
			public const string GetComputedStyleForNode = "CSS.getComputedStyleForNode";
			public const string GetInlineStylesForNode = "CSS.getInlineStylesForNode";
			public const string GetMatchedStylesForNode = "CSS.getMatchedStylesForNode";
			public const string GetMediaQueries = "CSS.getMediaQueries";
			public const string GetPlatformFontsForNode = "CSS.getPlatformFontsForNode";
			public const string GetStyleSheetText = "CSS.getStyleSheetText";
			public const string TrackComputedStyleUpdates = "CSS.trackComputedStyleUpdates";
			public const string TakeComputedStyleUpdates = "CSS.takeComputedStyleUpdates";
			public const string SetEffectivePropertyValueForNode = "CSS.setEffectivePropertyValueForNode";
			public const string SetKeyframeKey = "CSS.setKeyframeKey";
			public const string SetMediaText = "CSS.setMediaText";
			public const string SetContainerQueryText = "CSS.setContainerQueryText";
			public const string SetRuleSelector = "CSS.setRuleSelector";
			public const string SetStyleSheetText = "CSS.setStyleSheetText";
			public const string SetStyleTexts = "CSS.setStyleTexts";
			public const string StartRuleUsageTracking = "CSS.startRuleUsageTracking";
			public const string StopRuleUsageTracking = "CSS.stopRuleUsageTracking";
			public const string TakeCoverageDelta = "CSS.takeCoverageDelta";
			public const string SetLocalFontsEnabled = "CSS.setLocalFontsEnabled";
			public const string FontsUpdated = "CSS.fontsUpdated";
			public const string MediaQueryResultChanged = "CSS.mediaQueryResultChanged";
			public const string StyleSheetAdded = "CSS.styleSheetAdded";
			public const string StyleSheetChanged = "CSS.styleSheetChanged";
			public const string StyleSheetRemoved = "CSS.styleSheetRemoved";
		}

		public static class CacheStorage
		{
			public const string DeleteCache = "CacheStorage.deleteCache";
			public const string DeleteEntry = "CacheStorage.deleteEntry";
			public const string RequestCacheNames = "CacheStorage.requestCacheNames";
			public const string RequestCachedResponse = "CacheStorage.requestCachedResponse";
			public const string RequestEntries = "CacheStorage.requestEntries";
		}

		public static class Cast
		{
			public const string Enable = "Cast.enable";
			public const string Disable = "Cast.disable";
			public const string SetSinkToUse = "Cast.setSinkToUse";
			public const string StartTabMirroring = "Cast.startTabMirroring";
			public const string StopCasting = "Cast.stopCasting";
			public const string SinksUpdated = "Cast.sinksUpdated";
			public const string IssueUpdated = "Cast.issueUpdated";
		}

		public static class DOM
		{
			public const string CollectClassNamesFromSubtree = "DOM.collectClassNamesFromSubtree";
			public const string CopyTo = "DOM.copyTo";
			public const string DescribeNode = "DOM.describeNode";
			public const string ScrollIntoViewIfNeeded = "DOM.scrollIntoViewIfNeeded";
			public const string Disable = "DOM.disable";
			public const string DiscardSearchResults = "DOM.discardSearchResults";
			public const string Enable = "DOM.enable";
			public const string Focus = "DOM.focus";
			public const string GetAttributes = "DOM.getAttributes";
			public const string GetBoxModel = "DOM.getBoxModel";
			public const string GetContentQuads = "DOM.getContentQuads";
			public const string GetDocument = "DOM.getDocument";
			public const string GetFlattenedDocument = "DOM.getFlattenedDocument";
			public const string GetNodesForSubtreeByStyle = "DOM.getNodesForSubtreeByStyle";
			public const string GetNodeForLocation = "DOM.getNodeForLocation";
			public const string GetOuterHTML = "DOM.getOuterHTML";
			public const string GetRelayoutBoundary = "DOM.getRelayoutBoundary";
			public const string GetSearchResults = "DOM.getSearchResults";
			public const string HideHighlight = "DOM.hideHighlight";
			public const string HighlightNode = "DOM.highlightNode";
			public const string HighlightRect = "DOM.highlightRect";
			public const string MarkUndoableState = "DOM.markUndoableState";
			public const string MoveTo = "DOM.moveTo";
			public const string PerformSearch = "DOM.performSearch";
			public const string PushNodeByPathToFrontend = "DOM.pushNodeByPathToFrontend";
			public const string PushNodesByBackendIdsToFrontend = "DOM.pushNodesByBackendIdsToFrontend";
			public const string QuerySelector = "DOM.querySelector";
			public const string QuerySelectorAll = "DOM.querySelectorAll";
			public const string Redo = "DOM.redo";
			public const string RemoveAttribute = "DOM.removeAttribute";
			public const string RemoveNode = "DOM.removeNode";
			public const string RequestChildNodes = "DOM.requestChildNodes";
			public const string RequestNode = "DOM.requestNode";
			public const string ResolveNode = "DOM.resolveNode";
			public const string SetAttributeValue = "DOM.setAttributeValue";
			public const string SetAttributesAsText = "DOM.setAttributesAsText";
			public const string SetFileInputFiles = "DOM.setFileInputFiles";
			public const string SetNodeStackTracesEnabled = "DOM.setNodeStackTracesEnabled";
			public const string GetNodeStackTraces = "DOM.getNodeStackTraces";
			public const string GetFileInfo = "DOM.getFileInfo";
			public const string SetInspectedNode = "DOM.setInspectedNode";
			public const string SetNodeName = "DOM.setNodeName";
			public const string SetNodeValue = "DOM.setNodeValue";
			public const string SetOuterHTML = "DOM.setOuterHTML";
			public const string Undo = "DOM.undo";
			public const string GetFrameOwner = "DOM.getFrameOwner";
			public const string GetContainerForNode = "DOM.getContainerForNode";
			public const string GetQueryingDescendantsForContainer = "DOM.getQueryingDescendantsForContainer";
			public const string AttributeModified = "DOM.attributeModified";
			public const string AttributeRemoved = "DOM.attributeRemoved";
			public const string CharacterDataModified = "DOM.characterDataModified";
			public const string ChildNodeCountUpdated = "DOM.childNodeCountUpdated";
			public const string ChildNodeInserted = "DOM.childNodeInserted";
			public const string ChildNodeRemoved = "DOM.childNodeRemoved";
			public const string DistributedNodesUpdated = "DOM.distributedNodesUpdated";
			public const string DocumentUpdated = "DOM.documentUpdated";
			public const string InlineStyleInvalidated = "DOM.inlineStyleInvalidated";
			public const string PseudoElementAdded = "DOM.pseudoElementAdded";
			public const string PseudoElementRemoved = "DOM.pseudoElementRemoved";
			public const string SetChildNodes = "DOM.setChildNodes";
			public const string ShadowRootPopped = "DOM.shadowRootPopped";
			public const string ShadowRootPushed = "DOM.shadowRootPushed";
		}

		public static class DOMDebugger
		{
			public const string GetEventListeners = "DOMDebugger.getEventListeners";
			public const string RemoveDOMBreakpoint = "DOMDebugger.removeDOMBreakpoint";
			public const string RemoveEventListenerBreakpoint = "DOMDebugger.removeEventListenerBreakpoint";
			public const string RemoveInstrumentationBreakpoint = "DOMDebugger.removeInstrumentationBreakpoint";
			public const string RemoveXHRBreakpoint = "DOMDebugger.removeXHRBreakpoint";
			public const string SetBreakOnCSPViolation = "DOMDebugger.setBreakOnCSPViolation";
			public const string SetDOMBreakpoint = "DOMDebugger.setDOMBreakpoint";
			public const string SetEventListenerBreakpoint = "DOMDebugger.setEventListenerBreakpoint";
			public const string SetInstrumentationBreakpoint = "DOMDebugger.setInstrumentationBreakpoint";
			public const string SetXHRBreakpoint = "DOMDebugger.setXHRBreakpoint";
		}

		public static class DOMSnapshot
		{
			public const string Disable = "DOMSnapshot.disable";
			public const string Enable = "DOMSnapshot.enable";
			public const string GetSnapshot = "DOMSnapshot.getSnapshot";
			public const string CaptureSnapshot = "DOMSnapshot.captureSnapshot";
		}

		public static class DOMStorage
		{
			public const string Clear = "DOMStorage.clear";
			public const string Disable = "DOMStorage.disable";
			public const string Enable = "DOMStorage.enable";
			public const string GetDOMStorageItems = "DOMStorage.getDOMStorageItems";
			public const string RemoveDOMStorageItem = "DOMStorage.removeDOMStorageItem";
			public const string SetDOMStorageItem = "DOMStorage.setDOMStorageItem";
			public const string DomStorageItemAdded = "DOMStorage.domStorageItemAdded";
			public const string DomStorageItemRemoved = "DOMStorage.domStorageItemRemoved";
			public const string DomStorageItemUpdated = "DOMStorage.domStorageItemUpdated";
			public const string DomStorageItemsCleared = "DOMStorage.domStorageItemsCleared";
		}

		public static class Database
		{
			public const string Disable = "Database.disable";
			public const string Enable = "Database.enable";
			public const string ExecuteSQL = "Database.executeSQL";
			public const string GetDatabaseTableNames = "Database.getDatabaseTableNames";
			public const string AddDatabase = "Database.addDatabase";
		}

		public static class DeviceOrientation
		{
			public const string ClearDeviceOrientationOverride = "DeviceOrientation.clearDeviceOrientationOverride";
			public const string SetDeviceOrientationOverride = "DeviceOrientation.setDeviceOrientationOverride";
		}

		public static class Emulation
		{
			public const string CanEmulate = "Emulation.canEmulate";
			public const string ClearDeviceMetricsOverride = "Emulation.clearDeviceMetricsOverride";
			public const string ClearGeolocationOverride = "Emulation.clearGeolocationOverride";
			public const string ResetPageScaleFactor = "Emulation.resetPageScaleFactor";
			public const string SetFocusEmulationEnabled = "Emulation.setFocusEmulationEnabled";
			public const string SetAutoDarkModeOverride = "Emulation.setAutoDarkModeOverride";
			public const string SetCPUThrottlingRate = "Emulation.setCPUThrottlingRate";
			public const string SetDefaultBackgroundColorOverride = "Emulation.setDefaultBackgroundColorOverride";
			public const string SetDeviceMetricsOverride = "Emulation.setDeviceMetricsOverride";
			public const string SetScrollbarsHidden = "Emulation.setScrollbarsHidden";
			public const string SetDocumentCookieDisabled = "Emulation.setDocumentCookieDisabled";
			public const string SetEmitTouchEventsForMouse = "Emulation.setEmitTouchEventsForMouse";
			public const string SetEmulatedMedia = "Emulation.setEmulatedMedia";
			public const string SetEmulatedVisionDeficiency = "Emulation.setEmulatedVisionDeficiency";
			public const string SetGeolocationOverride = "Emulation.setGeolocationOverride";
			public const string SetIdleOverride = "Emulation.setIdleOverride";
			public const string ClearIdleOverride = "Emulation.clearIdleOverride";
			public const string SetNavigatorOverrides = "Emulation.setNavigatorOverrides";
			public const string SetPageScaleFactor = "Emulation.setPageScaleFactor";
			public const string SetScriptExecutionDisabled = "Emulation.setScriptExecutionDisabled";
			public const string SetTouchEmulationEnabled = "Emulation.setTouchEmulationEnabled";
			public const string SetVirtualTimePolicy = "Emulation.setVirtualTimePolicy";
			public const string SetLocaleOverride = "Emulation.setLocaleOverride";
			public const string SetTimezoneOverride = "Emulation.setTimezoneOverride";
			public const string SetVisibleSize = "Emulation.setVisibleSize";
			public const string SetDisabledImageTypes = "Emulation.setDisabledImageTypes";
			public const string SetUserAgentOverride = "Emulation.setUserAgentOverride";
			public const string VirtualTimeBudgetExpired = "Emulation.virtualTimeBudgetExpired";
		}

		public static class HeadlessExperimental
		{
			public const string BeginFrame = "HeadlessExperimental.beginFrame";
			public const string Disable = "HeadlessExperimental.disable";
			public const string Enable = "HeadlessExperimental.enable";
			public const string NeedsBeginFramesChanged = "HeadlessExperimental.needsBeginFramesChanged";
		}

		public static class IO
		{
			public const string Close = "IO.close";
			public const string Read = "IO.read";
			public const string ResolveBlob = "IO.resolveBlob";
		}

		public static class IndexedDB
		{
			public const string ClearObjectStore = "IndexedDB.clearObjectStore";
			public const string DeleteDatabase = "IndexedDB.deleteDatabase";
			public const string DeleteObjectStoreEntries = "IndexedDB.deleteObjectStoreEntries";
			public const string Disable = "IndexedDB.disable";
			public const string Enable = "IndexedDB.enable";
			public const string RequestData = "IndexedDB.requestData";
			public const string GetMetadata = "IndexedDB.getMetadata";
			public const string RequestDatabase = "IndexedDB.requestDatabase";
			public const string RequestDatabaseNames = "IndexedDB.requestDatabaseNames";
		}

		public static class Input
		{
			public const string DispatchDragEvent = "Input.dispatchDragEvent";
			public const string DispatchKeyEvent = "Input.dispatchKeyEvent";
			public const string InsertText = "Input.insertText";
			public const string ImeSetComposition = "Input.imeSetComposition";
			public const string DispatchMouseEvent = "Input.dispatchMouseEvent";
			public const string DispatchTouchEvent = "Input.dispatchTouchEvent";
			public const string EmulateTouchFromMouseEvent = "Input.emulateTouchFromMouseEvent";
			public const string SetIgnoreInputEvents = "Input.setIgnoreInputEvents";
			public const string SetInterceptDrags = "Input.setInterceptDrags";
			public const string SynthesizePinchGesture = "Input.synthesizePinchGesture";
			public const string SynthesizeScrollGesture = "Input.synthesizeScrollGesture";
			public const string SynthesizeTapGesture = "Input.synthesizeTapGesture";
			public const string DragIntercepted = "Input.dragIntercepted";
		}

		public static class Inspector
		{
			public const string Disable = "Inspector.disable";
			public const string Enable = "Inspector.enable";
			public const string Detached = "Inspector.detached";
			public const string TargetCrashed = "Inspector.targetCrashed";
			public const string TargetReloadedAfterCrash = "Inspector.targetReloadedAfterCrash";
		}

		public static class LayerTree
		{
			public const string CompositingReasons = "LayerTree.compositingReasons";
			public const string Disable = "LayerTree.disable";
			public const string Enable = "LayerTree.enable";
			public const string LoadSnapshot = "LayerTree.loadSnapshot";
			public const string MakeSnapshot = "LayerTree.makeSnapshot";
			public const string ProfileSnapshot = "LayerTree.profileSnapshot";
			public const string ReleaseSnapshot = "LayerTree.releaseSnapshot";
			public const string ReplaySnapshot = "LayerTree.replaySnapshot";
			public const string SnapshotCommandLog = "LayerTree.snapshotCommandLog";
			public const string LayerPainted = "LayerTree.layerPainted";
			public const string LayerTreeDidChange = "LayerTree.layerTreeDidChange";
		}

		public static class Log
		{
			public const string Clear = "Log.clear";
			public const string Disable = "Log.disable";
			public const string Enable = "Log.enable";
			public const string StartViolationsReport = "Log.startViolationsReport";
			public const string StopViolationsReport = "Log.stopViolationsReport";
			public const string EntryAdded = "Log.entryAdded";
		}

		public static class Memory
		{
			public const string GetDOMCounters = "Memory.getDOMCounters";
			public const string PrepareForLeakDetection = "Memory.prepareForLeakDetection";
			public const string ForciblyPurgeJavaScriptMemory = "Memory.forciblyPurgeJavaScriptMemory";
			public const string SetPressureNotificationsSuppressed = "Memory.setPressureNotificationsSuppressed";
			public const string SimulatePressureNotification = "Memory.simulatePressureNotification";
			public const string StartSampling = "Memory.startSampling";
			public const string StopSampling = "Memory.stopSampling";
			public const string GetAllTimeSamplingProfile = "Memory.getAllTimeSamplingProfile";
			public const string GetBrowserSamplingProfile = "Memory.getBrowserSamplingProfile";
			public const string GetSamplingProfile = "Memory.getSamplingProfile";
		}

		public static class Network
		{
			public const string SetAcceptedEncodings = "Network.setAcceptedEncodings";
			public const string ClearAcceptedEncodingsOverride = "Network.clearAcceptedEncodingsOverride";
			public const string CanClearBrowserCache = "Network.canClearBrowserCache";
			public const string CanClearBrowserCookies = "Network.canClearBrowserCookies";
			public const string CanEmulateNetworkConditions = "Network.canEmulateNetworkConditions";
			public const string ClearBrowserCache = "Network.clearBrowserCache";
			public const string ClearBrowserCookies = "Network.clearBrowserCookies";
			public const string ContinueInterceptedRequest = "Network.continueInterceptedRequest";
			public const string DeleteCookies = "Network.deleteCookies";
			public const string Disable = "Network.disable";
			public const string EmulateNetworkConditions = "Network.emulateNetworkConditions";
			public const string Enable = "Network.enable";
			public const string GetAllCookies = "Network.getAllCookies";
			public const string GetCertificate = "Network.getCertificate";
			public const string GetCookies = "Network.getCookies";
			public const string GetResponseBody = "Network.getResponseBody";
			public const string GetRequestPostData = "Network.getRequestPostData";
			public const string GetResponseBodyForInterception = "Network.getResponseBodyForInterception";
			public const string TakeResponseBodyForInterceptionAsStream = "Network.takeResponseBodyForInterceptionAsStream";
			public const string ReplayXHR = "Network.replayXHR";
			public const string SearchInResponseBody = "Network.searchInResponseBody";
			public const string SetBlockedURLs = "Network.setBlockedURLs";
			public const string SetBypassServiceWorker = "Network.setBypassServiceWorker";
			public const string SetCacheDisabled = "Network.setCacheDisabled";
			public const string SetCookie = "Network.setCookie";
			public const string SetCookies = "Network.setCookies";
			public const string SetExtraHTTPHeaders = "Network.setExtraHTTPHeaders";
			public const string SetAttachDebugStack = "Network.setAttachDebugStack";
			public const string SetRequestInterception = "Network.setRequestInterception";
			public const string SetUserAgentOverride = "Network.setUserAgentOverride";
			public const string GetSecurityIsolationStatus = "Network.getSecurityIsolationStatus";
			public const string EnableReportingApi = "Network.enableReportingApi";
			public const string LoadNetworkResource = "Network.loadNetworkResource";
			public const string DataReceived = "Network.dataReceived";
			public const string EventSourceMessageReceived = "Network.eventSourceMessageReceived";
			public const string LoadingFailed = "Network.loadingFailed";
			public const string LoadingFinished = "Network.loadingFinished";
			public const string RequestIntercepted = "Network.requestIntercepted";
			public const string RequestServedFromCache = "Network.requestServedFromCache";
			public const string RequestWillBeSent = "Network.requestWillBeSent";
			public const string ResourceChangedPriority = "Network.resourceChangedPriority";
			public const string SignedExchangeReceived = "Network.signedExchangeReceived";
			public const string ResponseReceived = "Network.responseReceived";
			public const string WebSocketClosed = "Network.webSocketClosed";
			public const string WebSocketCreated = "Network.webSocketCreated";
			public const string WebSocketFrameError = "Network.webSocketFrameError";
			public const string WebSocketFrameReceived = "Network.webSocketFrameReceived";
			public const string WebSocketFrameSent = "Network.webSocketFrameSent";
			public const string WebSocketHandshakeResponseReceived = "Network.webSocketHandshakeResponseReceived";
			public const string WebSocketWillSendHandshakeRequest = "Network.webSocketWillSendHandshakeRequest";
			public const string WebTransportCreated = "Network.webTransportCreated";
			public const string WebTransportConnectionEstablished = "Network.webTransportConnectionEstablished";
			public const string WebTransportClosed = "Network.webTransportClosed";
			public const string RequestWillBeSentExtraInfo = "Network.requestWillBeSentExtraInfo";
			public const string ResponseReceivedExtraInfo = "Network.responseReceivedExtraInfo";
			public const string TrustTokenOperationDone = "Network.trustTokenOperationDone";
			public const string SubresourceWebBundleMetadataReceived = "Network.subresourceWebBundleMetadataReceived";
			public const string SubresourceWebBundleMetadataError = "Network.subresourceWebBundleMetadataError";
			public const string SubresourceWebBundleInnerResponseParsed = "Network.subresourceWebBundleInnerResponseParsed";
			public const string SubresourceWebBundleInnerResponseError = "Network.subresourceWebBundleInnerResponseError";
			public const string ReportingApiReportAdded = "Network.reportingApiReportAdded";
			public const string ReportingApiReportUpdated = "Network.reportingApiReportUpdated";
		}

		public static class Overlay
		{
			public const string Disable = "Overlay.disable";
			public const string Enable = "Overlay.enable";
			public const string GetHighlightObjectForTest = "Overlay.getHighlightObjectForTest";
			public const string GetGridHighlightObjectsForTest = "Overlay.getGridHighlightObjectsForTest";
			public const string GetSourceOrderHighlightObjectForTest = "Overlay.getSourceOrderHighlightObjectForTest";
			public const string HideHighlight = "Overlay.hideHighlight";
			public const string HighlightFrame = "Overlay.highlightFrame";
			public const string HighlightNode = "Overlay.highlightNode";
			public const string HighlightQuad = "Overlay.highlightQuad";
			public const string HighlightRect = "Overlay.highlightRect";
			public const string HighlightSourceOrder = "Overlay.highlightSourceOrder";
			public const string SetInspectMode = "Overlay.setInspectMode";
			public const string SetShowAdHighlights = "Overlay.setShowAdHighlights";
			public const string SetPausedInDebuggerMessage = "Overlay.setPausedInDebuggerMessage";
			public const string SetShowDebugBorders = "Overlay.setShowDebugBorders";
			public const string SetShowFPSCounter = "Overlay.setShowFPSCounter";
			public const string SetShowGridOverlays = "Overlay.setShowGridOverlays";
			public const string SetShowFlexOverlays = "Overlay.setShowFlexOverlays";
			public const string SetShowScrollSnapOverlays = "Overlay.setShowScrollSnapOverlays";
			public const string SetShowContainerQueryOverlays = "Overlay.setShowContainerQueryOverlays";
			public const string SetShowPaintRects = "Overlay.setShowPaintRects";
			public const string SetShowLayoutShiftRegions = "Overlay.setShowLayoutShiftRegions";
			public const string SetShowScrollBottleneckRects = "Overlay.setShowScrollBottleneckRects";
			public const string SetShowHitTestBorders = "Overlay.setShowHitTestBorders";
			public const string SetShowWebVitals = "Overlay.setShowWebVitals";
			public const string SetShowViewportSizeOnResize = "Overlay.setShowViewportSizeOnResize";
			public const string SetShowHinge = "Overlay.setShowHinge";
			public const string InspectNodeRequested = "Overlay.inspectNodeRequested";
			public const string NodeHighlightRequested = "Overlay.nodeHighlightRequested";
			public const string ScreenshotRequested = "Overlay.screenshotRequested";
			public const string InspectModeCanceled = "Overlay.inspectModeCanceled";
		}

		public static class Page
		{
			public const string AddScriptToEvaluateOnLoad = "Page.addScriptToEvaluateOnLoad";
			public const string AddScriptToEvaluateOnNewDocument = "Page.addScriptToEvaluateOnNewDocument";
			public const string BringToFront = "Page.bringToFront";
			public const string CaptureScreenshot = "Page.captureScreenshot";
			public const string CaptureSnapshot = "Page.captureSnapshot";
			public const string ClearDeviceMetricsOverride = "Page.clearDeviceMetricsOverride";
			public const string ClearDeviceOrientationOverride = "Page.clearDeviceOrientationOverride";
			public const string ClearGeolocationOverride = "Page.clearGeolocationOverride";
			public const string CreateIsolatedWorld = "Page.createIsolatedWorld";
			public const string DeleteCookie = "Page.deleteCookie";
			public const string Disable = "Page.disable";
			public const string Enable = "Page.enable";
			public const string GetAppManifest = "Page.getAppManifest";
			public const string GetInstallabilityErrors = "Page.getInstallabilityErrors";
			public const string GetManifestIcons = "Page.getManifestIcons";
			public const string GetAppId = "Page.getAppId";
			public const string GetCookies = "Page.getCookies";
			public const string GetFrameTree = "Page.getFrameTree";
			public const string GetLayoutMetrics = "Page.getLayoutMetrics";
			public const string GetNavigationHistory = "Page.getNavigationHistory";
			public const string ResetNavigationHistory = "Page.resetNavigationHistory";
			public const string GetResourceContent = "Page.getResourceContent";
			public const string GetResourceTree = "Page.getResourceTree";
			public const string HandleJavaScriptDialog = "Page.handleJavaScriptDialog";
			public const string Navigate = "Page.navigate";
			public const string NavigateToHistoryEntry = "Page.navigateToHistoryEntry";
			public const string PrintToPDF = "Page.printToPDF";
			public const string Reload = "Page.reload";
			public const string RemoveScriptToEvaluateOnLoad = "Page.removeScriptToEvaluateOnLoad";
			public const string RemoveScriptToEvaluateOnNewDocument = "Page.removeScriptToEvaluateOnNewDocument";
			public const string ScreencastFrameAck = "Page.screencastFrameAck";
			public const string SearchInResource = "Page.searchInResource";
			public const string SetAdBlockingEnabled = "Page.setAdBlockingEnabled";
			public const string SetBypassCSP = "Page.setBypassCSP";
			public const string GetPermissionsPolicyState = "Page.getPermissionsPolicyState";
			public const string GetOriginTrials = "Page.getOriginTrials";
			public const string SetDeviceMetricsOverride = "Page.setDeviceMetricsOverride";
			public const string SetDeviceOrientationOverride = "Page.setDeviceOrientationOverride";
			public const string SetFontFamilies = "Page.setFontFamilies";
			public const string SetFontSizes = "Page.setFontSizes";
			public const string SetDocumentContent = "Page.setDocumentContent";
			public const string SetDownloadBehavior = "Page.setDownloadBehavior";
			public const string SetGeolocationOverride = "Page.setGeolocationOverride";
			public const string SetLifecycleEventsEnabled = "Page.setLifecycleEventsEnabled";
			public const string SetTouchEmulationEnabled = "Page.setTouchEmulationEnabled";
			public const string StartScreencast = "Page.startScreencast";
			public const string StopLoading = "Page.stopLoading";
			public const string Crash = "Page.crash";
			public const string Close = "Page.close";
			public const string SetWebLifecycleState = "Page.setWebLifecycleState";
			public const string StopScreencast = "Page.stopScreencast";
			public const string SetProduceCompilationCache = "Page.setProduceCompilationCache";
			public const string ProduceCompilationCache = "Page.produceCompilationCache";
			public const string AddCompilationCache = "Page.addCompilationCache";
			public const string ClearCompilationCache = "Page.clearCompilationCache";
			public const string GenerateTestReport = "Page.generateTestReport";
			public const string WaitForDebugger = "Page.waitForDebugger";
			public const string SetInterceptFileChooserDialog = "Page.setInterceptFileChooserDialog";
			public const string DomContentEventFired = "Page.domContentEventFired";
			public const string FileChooserOpened = "Page.fileChooserOpened";
			public const string FrameAttached = "Page.frameAttached";
			public const string FrameClearedScheduledNavigation = "Page.frameClearedScheduledNavigation";
			public const string FrameDetached = "Page.frameDetached";
			public const string FrameNavigated = "Page.frameNavigated";
			public const string DocumentOpened = "Page.documentOpened";
			public const string FrameResized = "Page.frameResized";
			public const string FrameRequestedNavigation = "Page.frameRequestedNavigation";
			public const string FrameScheduledNavigation = "Page.frameScheduledNavigation";
			public const string FrameStartedLoading = "Page.frameStartedLoading";
			public const string FrameStoppedLoading = "Page.frameStoppedLoading";
			public const string DownloadWillBegin = "Page.downloadWillBegin";
			public const string DownloadProgress = "Page.downloadProgress";
			public const string InterstitialHidden = "Page.interstitialHidden";
			public const string InterstitialShown = "Page.interstitialShown";
			public const string JavascriptDialogClosed = "Page.javascriptDialogClosed";
			public const string JavascriptDialogOpening = "Page.javascriptDialogOpening";
			public const string LifecycleEvent = "Page.lifecycleEvent";
			public const string BackForwardCacheNotUsed = "Page.backForwardCacheNotUsed";
			public const string LoadEventFired = "Page.loadEventFired";
			public const string NavigatedWithinDocument = "Page.navigatedWithinDocument";
			public const string ScreencastFrame = "Page.screencastFrame";
			public const string ScreencastVisibilityChanged = "Page.screencastVisibilityChanged";
			public const string WindowOpen = "Page.windowOpen";
			public const string CompilationCacheProduced = "Page.compilationCacheProduced";
		}

		public static class Performance
		{
			public const string Disable = "Performance.disable";
			public const string Enable = "Performance.enable";
			public const string SetTimeDomain = "Performance.setTimeDomain";
			public const string GetMetrics = "Performance.getMetrics";
			public const string Metrics = "Performance.metrics";
		}

		public static class PerformanceTimeline
		{
			public const string Enable = "PerformanceTimeline.enable";
			public const string TimelineEventAdded = "PerformanceTimeline.timelineEventAdded";
		}

		public static class Security
		{
			public const string Disable = "Security.disable";
			public const string Enable = "Security.enable";
			public const string SetIgnoreCertificateErrors = "Security.setIgnoreCertificateErrors";
			public const string HandleCertificateError = "Security.handleCertificateError";
			public const string SetOverrideCertificateErrors = "Security.setOverrideCertificateErrors";
			public const string CertificateError = "Security.certificateError";
			public const string VisibleSecurityStateChanged = "Security.visibleSecurityStateChanged";
			public const string SecurityStateChanged = "Security.securityStateChanged";
		}

		public static class ServiceWorker
		{
			public const string DeliverPushMessage = "ServiceWorker.deliverPushMessage";
			public const string Disable = "ServiceWorker.disable";
			public const string DispatchSyncEvent = "ServiceWorker.dispatchSyncEvent";
			public const string DispatchPeriodicSyncEvent = "ServiceWorker.dispatchPeriodicSyncEvent";
			public const string Enable = "ServiceWorker.enable";
			public const string InspectWorker = "ServiceWorker.inspectWorker";
			public const string SetForceUpdateOnPageLoad = "ServiceWorker.setForceUpdateOnPageLoad";
			public const string SkipWaiting = "ServiceWorker.skipWaiting";
			public const string StartWorker = "ServiceWorker.startWorker";
			public const string StopAllWorkers = "ServiceWorker.stopAllWorkers";
			public const string StopWorker = "ServiceWorker.stopWorker";
			public const string Unregister = "ServiceWorker.unregister";
			public const string UpdateRegistration = "ServiceWorker.updateRegistration";
			public const string WorkerErrorReported = "ServiceWorker.workerErrorReported";
			public const string WorkerRegistrationUpdated = "ServiceWorker.workerRegistrationUpdated";
			public const string WorkerVersionUpdated = "ServiceWorker.workerVersionUpdated";
		}

		public static class Storage
		{
			public const string ClearDataForOrigin = "Storage.clearDataForOrigin";
			public const string GetCookies = "Storage.getCookies";
			public const string SetCookies = "Storage.setCookies";
			public const string ClearCookies = "Storage.clearCookies";
			public const string GetUsageAndQuota = "Storage.getUsageAndQuota";
			public const string OverrideQuotaForOrigin = "Storage.overrideQuotaForOrigin";
			public const string TrackCacheStorageForOrigin = "Storage.trackCacheStorageForOrigin";
			public const string TrackIndexedDBForOrigin = "Storage.trackIndexedDBForOrigin";
			public const string UntrackCacheStorageForOrigin = "Storage.untrackCacheStorageForOrigin";
			public const string UntrackIndexedDBForOrigin = "Storage.untrackIndexedDBForOrigin";
			public const string GetTrustTokens = "Storage.getTrustTokens";
			public const string ClearTrustTokens = "Storage.clearTrustTokens";
			public const string CacheStorageContentUpdated = "Storage.cacheStorageContentUpdated";
			public const string CacheStorageListUpdated = "Storage.cacheStorageListUpdated";
			public const string IndexedDBContentUpdated = "Storage.indexedDBContentUpdated";
			public const string IndexedDBListUpdated = "Storage.indexedDBListUpdated";
		}

		public static class SystemInfo
		{
			public const string GetInfo = "SystemInfo.getInfo";
			public const string GetProcessInfo = "SystemInfo.getProcessInfo";
		}

		public static class Target
		{
			public const string ActivateTarget = "Target.activateTarget";
			public const string AttachToTarget = "Target.attachToTarget";
			public const string AttachToBrowserTarget = "Target.attachToBrowserTarget";
			public const string CloseTarget = "Target.closeTarget";
			public const string ExposeDevToolsProtocol = "Target.exposeDevToolsProtocol";
			public const string CreateBrowserContext = "Target.createBrowserContext";
			public const string GetBrowserContexts = "Target.getBrowserContexts";
			public const string CreateTarget = "Target.createTarget";
			public const string DetachFromTarget = "Target.detachFromTarget";
			public const string DisposeBrowserContext = "Target.disposeBrowserContext";
			public const string GetTargetInfo = "Target.getTargetInfo";
			public const string GetTargets = "Target.getTargets";
			public const string SendMessageToTarget = "Target.sendMessageToTarget";
			public const string SetAutoAttach = "Target.setAutoAttach";
			public const string AutoAttachRelated = "Target.autoAttachRelated";
			public const string SetDiscoverTargets = "Target.setDiscoverTargets";
			public const string SetRemoteLocations = "Target.setRemoteLocations";
			public const string AttachedToTarget = "Target.attachedToTarget";
			public const string DetachedFromTarget = "Target.detachedFromTarget";
			public const string ReceivedMessageFromTarget = "Target.receivedMessageFromTarget";
			public const string TargetCreated = "Target.targetCreated";
			public const string TargetDestroyed = "Target.targetDestroyed";
			public const string TargetCrashed = "Target.targetCrashed";
			public const string TargetInfoChanged = "Target.targetInfoChanged";
		}

		public static class Tethering
		{
			public const string Bind = "Tethering.bind";
			public const string Unbind = "Tethering.unbind";
			public const string Accepted = "Tethering.accepted";
		}

		public static class Tracing
		{
			public const string End = "Tracing.end";
			public const string GetCategories = "Tracing.getCategories";
			public const string RecordClockSyncMarker = "Tracing.recordClockSyncMarker";
			public const string RequestMemoryDump = "Tracing.requestMemoryDump";
			public const string Start = "Tracing.start";
			public const string BufferUsage = "Tracing.bufferUsage";
			public const string DataCollected = "Tracing.dataCollected";
			public const string TracingComplete = "Tracing.tracingComplete";
		}

		public static class Fetch
		{
			public const string Disable = "Fetch.disable";
			public const string Enable = "Fetch.enable";
			public const string FailRequest = "Fetch.failRequest";
			public const string FulfillRequest = "Fetch.fulfillRequest";
			public const string ContinueRequest = "Fetch.continueRequest";
			public const string ContinueWithAuth = "Fetch.continueWithAuth";
			public const string ContinueResponse = "Fetch.continueResponse";
			public const string GetResponseBody = "Fetch.getResponseBody";
			public const string TakeResponseBodyAsStream = "Fetch.takeResponseBodyAsStream";
			public const string RequestPaused = "Fetch.requestPaused";
			public const string AuthRequired = "Fetch.authRequired";
		}

		public static class WebAudio
		{
			public const string Enable = "WebAudio.enable";
			public const string Disable = "WebAudio.disable";
			public const string GetRealtimeData = "WebAudio.getRealtimeData";
			public const string ContextCreated = "WebAudio.contextCreated";
			public const string ContextWillBeDestroyed = "WebAudio.contextWillBeDestroyed";
			public const string ContextChanged = "WebAudio.contextChanged";
			public const string AudioListenerCreated = "WebAudio.audioListenerCreated";
			public const string AudioListenerWillBeDestroyed = "WebAudio.audioListenerWillBeDestroyed";
			public const string AudioNodeCreated = "WebAudio.audioNodeCreated";
			public const string AudioNodeWillBeDestroyed = "WebAudio.audioNodeWillBeDestroyed";
			public const string AudioParamCreated = "WebAudio.audioParamCreated";
			public const string AudioParamWillBeDestroyed = "WebAudio.audioParamWillBeDestroyed";
			public const string NodesConnected = "WebAudio.nodesConnected";
			public const string NodesDisconnected = "WebAudio.nodesDisconnected";
			public const string NodeParamConnected = "WebAudio.nodeParamConnected";
			public const string NodeParamDisconnected = "WebAudio.nodeParamDisconnected";
		}

		public static class WebAuthn
		{
			public const string Enable = "WebAuthn.enable";
			public const string Disable = "WebAuthn.disable";
			public const string AddVirtualAuthenticator = "WebAuthn.addVirtualAuthenticator";
			public const string RemoveVirtualAuthenticator = "WebAuthn.removeVirtualAuthenticator";
			public const string AddCredential = "WebAuthn.addCredential";
			public const string GetCredential = "WebAuthn.getCredential";
			public const string GetCredentials = "WebAuthn.getCredentials";
			public const string RemoveCredential = "WebAuthn.removeCredential";
			public const string ClearCredentials = "WebAuthn.clearCredentials";
			public const string SetUserVerified = "WebAuthn.setUserVerified";
			public const string SetAutomaticPresenceSimulation = "WebAuthn.setAutomaticPresenceSimulation";
		}

		public static class Media
		{
			public const string Enable = "Media.enable";
			public const string Disable = "Media.disable";
			public const string PlayerPropertiesChanged = "Media.playerPropertiesChanged";
			public const string PlayerEventsAdded = "Media.playerEventsAdded";
			public const string PlayerMessagesLogged = "Media.playerMessagesLogged";
			public const string PlayerErrorsRaised = "Media.playerErrorsRaised";
			public const string PlayersCreated = "Media.playersCreated";
		}

	}
}
