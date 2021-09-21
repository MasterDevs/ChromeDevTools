using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// Values of AXProperty name:
	///- from 'busy' to 'roledescription': states which apply to every AX node
	///- from 'live' to 'root': attributes which apply to nodes in live regions
	///- from 'autocomplete' to 'valuetext': attributes which apply to widgets
	///- from 'checked' to 'selected': states which apply to widgets
	///- from 'activedescendant' to 'owns' - relationships between elements other than parent/child/sibling.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXPropertyName
	{
			Busy,
			Disabled,
			Editable,
			Focusable,
			Focused,
			Hidden,
			HiddenRoot,
			Invalid,
			Keyshortcuts,
			Settable,
			Roledescription,
			Live,
			Atomic,
			Relevant,
			Root,
			Autocomplete,
			HasPopup,
			Level,
			Multiselectable,
			Orientation,
			Multiline,
			Readonly,
			Required,
			Valuemin,
			Valuemax,
			Valuetext,
			Checked,
			Expanded,
			Modal,
			Pressed,
			Selected,
			Activedescendant,
			Controls,
			Describedby,
			Details,
			Errormessage,
			Flowto,
			Labelledby,
			Owns,
	}
}
