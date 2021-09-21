using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Describes a single graphics processor (GPU).
	/// </summary>
	[SupportedBy("Chrome")]
	public class GPUDevice
	{
		/// <summary>
		/// Gets or sets PCI ID of the GPU vendor, if available; 0 otherwise.
		/// </summary>
		public double VendorId { get; set; }
		/// <summary>
		/// Gets or sets PCI ID of the GPU device, if available; 0 otherwise.
		/// </summary>
		public double DeviceId { get; set; }
		/// <summary>
		/// Gets or sets Sub sys ID of the GPU, only available on Windows.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double SubSysId { get; set; }
		/// <summary>
		/// Gets or sets Revision of the GPU, only available on Windows.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Revision { get; set; }
		/// <summary>
		/// Gets or sets String description of the GPU vendor, if the PCI ID is not available.
		/// </summary>
		public string VendorString { get; set; }
		/// <summary>
		/// Gets or sets String description of the GPU device, if the PCI ID is not available.
		/// </summary>
		public string DeviceString { get; set; }
		/// <summary>
		/// Gets or sets String description of the GPU driver vendor.
		/// </summary>
		public string DriverVendor { get; set; }
		/// <summary>
		/// Gets or sets String description of the GPU driver version.
		/// </summary>
		public string DriverVersion { get; set; }
	}
}
