namespace ScheduleOne.Management
{
	public class PresetEditScreen : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class OptionData
		{
			public global::UnityEngine.GameObject OptionEntryPrefab;

			public global::ScheduleOne.Management.Presets.Options.SetterScreens.OptionSetterScreen OptionSetterScreen;
		}

		public global::ScheduleOne.Management.Presets.Preset EditedPreset;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform IconBackgroundRect;

		public global::UnityEngine.UI.Image IconBackground;

		public global::UnityEngine.RectTransform InputFieldRect;

		public global::TMPro.TMP_InputField InputField;

		public global::UnityEngine.RectTransform EditButtonRect;

		public global::UnityEngine.UI.Button ReturnButton;

		public global::UnityEngine.UI.Button DeleteButton;

		public bool isOpen => false;

		protected virtual void Awake()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public virtual void Open(global::ScheduleOne.Management.Presets.Preset preset)
		{
		}

		public void Close()
		{
		}

		private void RefreshIcon()
		{
		}

		private void RefreshTransforms()
		{
		}

		private void NameFieldChange(string newVal)
		{
		}

		private void NameFieldDone(string piss)
		{
		}

		private bool IsNameAppropriate(string name)
		{
			return false;
		}

		public void DeleteButtonClicked()
		{
		}

		public void ReturnButtonClicked()
		{
		}
	}
}
