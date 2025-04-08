namespace ScheduleOne.UI.Management
{
	public class ItemSelector : global::ScheduleOne.UI.Management.ClipboardScreen
	{
		[global::System.Serializable]
		public class Option
		{
			public string Title;

			public global::ScheduleOne.ItemFramework.ItemDefinition Item;

			public Option(string title, global::ScheduleOne.ItemFramework.ItemDefinition item)
			{
			}
		}

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform OptionContainer;

		public global::TMPro.TextMeshProUGUI TitleLabel;

		public global::TMPro.TextMeshProUGUI HoveredItemLabel;

		public global::UnityEngine.GameObject OptionPrefab;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Sprite EmptyOptionSprite;

		private global::UnityEngine.Coroutine lerpRoutine;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Management.ItemSelector.Option> options;

		private global::ScheduleOne.UI.Management.ItemSelector.Option selectedOption;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> optionButtons;

		private global::System.Action<global::ScheduleOne.UI.Management.ItemSelector.Option> optionCallback;

		public void Initialize(string selectionTitle, global::System.Collections.Generic.List<global::ScheduleOne.UI.Management.ItemSelector.Option> _options, global::ScheduleOne.UI.Management.ItemSelector.Option _selectedOption = null, global::System.Action<global::ScheduleOne.UI.Management.ItemSelector.Option> _optionCallback = null)
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		private void ButtonClicked(global::ScheduleOne.UI.Management.ItemSelector.Option option)
		{
		}

		private void ButtonHovered(global::ScheduleOne.UI.Management.ItemSelector.Option option)
		{
		}

		private void ButtonHoverEnd(global::ScheduleOne.UI.Management.ItemSelector.Option option)
		{
		}

		private void CreateOptions(global::System.Collections.Generic.List<global::ScheduleOne.UI.Management.ItemSelector.Option> options)
		{
		}

		private void DeleteOptions()
		{
		}
	}
}
