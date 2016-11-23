using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM{
	/// <summary>
	/// Pseudo element type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PseudoType
	{
			[EnumMember(Value = "first-line")]
			First_line,
			[EnumMember(Value = "first-letter")]
			First_letter,
			Before,
			After,
			Backdrop,
			Selection,
			[EnumMember(Value = "first-line-inherited")]
			First_line_inherited,
			Scrollbar,
			[EnumMember(Value = "scrollbar-thumb")]
			Scrollbar_thumb,
			[EnumMember(Value = "scrollbar-button")]
			Scrollbar_button,
			[EnumMember(Value = "scrollbar-track")]
			Scrollbar_track,
			[EnumMember(Value = "scrollbar-track-piece")]
			Scrollbar_track_piece,
			[EnumMember(Value = "scrollbar-corner")]
			Scrollbar_corner,
			Resizer,
			[EnumMember(Value = "input-list-button")]
			Input_list_button,
	}
}
