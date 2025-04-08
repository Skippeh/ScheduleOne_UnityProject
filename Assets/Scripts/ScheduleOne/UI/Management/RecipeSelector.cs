namespace ScheduleOne.UI.Management
{
	public class RecipeSelector : global::ScheduleOne.UI.Management.ClipboardScreen
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform OptionContainer;

		public global::TMPro.TextMeshProUGUI TitleLabel;

		public global::UnityEngine.GameObject OptionPrefab;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Sprite EmptyOptionSprite;

		private global::UnityEngine.Coroutine lerpRoutine;

		private global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationRecipe> options;

		private global::ScheduleOne.StationFramework.StationRecipe selectedOption;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> optionButtons;

		private global::System.Action<global::ScheduleOne.StationFramework.StationRecipe> optionCallback;

		public void Initialize(string selectionTitle, global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationRecipe> _options, global::ScheduleOne.StationFramework.StationRecipe _selectedOption = null, global::System.Action<global::ScheduleOne.StationFramework.StationRecipe> _optionCallback = null)
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		private void ButtonClicked(global::ScheduleOne.StationFramework.StationRecipe option)
		{
		}

		private void CreateOptions(global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationRecipe> options)
		{
		}

		private void DeleteOptions()
		{
		}
	}
}
