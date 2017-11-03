using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// An explanation of an factor contributing to the security state.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SecurityStateExplanation
	{
		/// <summary>
		/// Gets or sets Security state representing the severity of the factor being explained.
		/// </summary>
		public SecurityState SecurityState { get; set; }
		/// <summary>
		/// Gets or sets Short phrase describing the type of factor.
		/// </summary>
		public string Summary { get; set; }
		/// <summary>
		/// Gets or sets Full text explanation of the factor.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets The type of mixed content described by the explanation.
		/// </summary>
		public MixedContentType MixedContentType { get; set; }
		/// <summary>
		/// Gets or sets Page certificate.
		/// </summary>
		public string[] Certificate { get; set; }
	}
}
