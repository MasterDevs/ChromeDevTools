using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	[CommandResponse(ProtocolName.DOMStorage.RemoveDOMStorageItem)]
	[SupportedBy("iOS")]
	public class RemoveDOMStorageItemCommandResponse
	{
	}
}
