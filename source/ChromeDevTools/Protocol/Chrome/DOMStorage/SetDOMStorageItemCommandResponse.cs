using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[CommandResponse(ProtocolName.DOMStorage.SetDOMStorageItem)]
	[SupportedBy("Chrome")]
	public class SetDOMStorageItemCommandResponse
	{
	}
}
