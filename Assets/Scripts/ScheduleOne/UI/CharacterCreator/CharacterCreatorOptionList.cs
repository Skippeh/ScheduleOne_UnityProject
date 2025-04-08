namespace ScheduleOne.UI.CharacterCreator
{
	public class CharacterCreatorOptionList : global::ScheduleOne.UI.CharacterCreator.CharacterCreatorField<string>
	{
		[global::System.Serializable]
		public class Option
		{
			public string Label;

			public string AssetPath;

			public global::ScheduleOne.Clothing.ClothingDefinition ClothingItemEquivalent;
		}

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform OptionContainer;

		[global::UnityEngine.Header("Settings")]
		public bool CanSelectNone;

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.CharacterCreator.CharacterCreatorOptionList.Option> Options;

		public global::UnityEngine.GameObject OptionPrefab;

		private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> optionButtons;

		private global::UnityEngine.UI.Button selectedButton;

		protected override void Awake()
		{
		}

		public override void ApplyValue()
		{
		}

		public void OptionClicked(string option)
		{
		}
	}
}
