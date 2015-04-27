using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Cookie object
	/// </summary>
	public class Cookie
	{
		/// <summary>
		/// Gets or sets Cookie name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Cookie value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Cookie domain.
		/// </summary>
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets Cookie path.
		/// </summary>
		public string Path { get; set; }
		/// <summary>
		/// Gets or sets Cookie expires.
		/// </summary>
		public double Expires { get; set; }
		/// <summary>
		/// Gets or sets Cookie size.
		/// </summary>
		public long Size { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is http-only.
		/// </summary>
		public bool HttpOnly { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is secure.
		/// </summary>
		public bool Secure { get; set; }
		/// <summary>
		/// Gets or sets True in case of session cookie.
		/// </summary>
		public bool Session { get; set; }
	}
}
