namespace ScheduleOne.UI.Settings
{
	public class SettingsDropdown : global::UnityEngine.MonoBehaviour
	{
		public string[] DefaultOptions;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.UIPopupSelector _popupSelector;

		private global::TMPro.TMP_Dropdown _dropdown;

		protected virtual void Awake()
		{
		}

		protected void SetValueWithoutNotify(int value)
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnValueChanged(int value)
		{
		}

		protected void AddOption(string option)
		{
		}

		protected void AddOptions(global::System.Collections.Generic.List<string> options)
		{
		}

		protected void ClearOptions()
		{
		}
	}
}
