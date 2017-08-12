using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Displays native dialog with the certificate details.
	/// </summary>
	[Command(ProtocolName.Security.ShowCertificateViewer)]
	[SupportedBy("Chrome")]
	public class ShowCertificateViewerCommand: ICommand<ShowCertificateViewerCommandResponse>
	{
	}
}
