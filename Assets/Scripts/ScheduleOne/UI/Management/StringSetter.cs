namespace ScheduleOne.UI.Management
{
	public class StringSetter : global::ScheduleOne.UI.Management.ClipboardScreen
	{
		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI TitleLabel;

		public global::TMPro.TMP_InputField InputField;

		public global::UnityEngine.UI.Button DoneButton;

		private string _existingValue;

		private bool _allowEmpty;

		private global::System.Action<string> _callback;

		private void Awake()
		{
		}

		public void Initialize(string selectionTitle, string existingValue, int characterLimit, bool allowEmpty, global::System.Action<string> callback = null)
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		private void DoneButtonPressed()
		{
		}

		private void OnSubmit(string value)
		{
		}
	}
}
