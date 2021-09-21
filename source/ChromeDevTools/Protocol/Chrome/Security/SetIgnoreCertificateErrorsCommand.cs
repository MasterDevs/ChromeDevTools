using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Enable/disable whether all certificate errors should be ignored.
	/// </summary>
	[Command(ProtocolName.Security.SetIgnoreCertificateErrors)]
	[SupportedBy("Chrome")]
	public class SetIgnoreCertificateErrorsCommand: ICommand<SetIgnoreCertificateErrorsCommandResponse>
	{
		/// <summary>
		/// Gets or sets If true, all certificate errors will be ignored.
		/// </summary>
		public bool Ignore { get; set; }
	}
}
