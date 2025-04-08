namespace ScheduleOne.UI.CharacterCreator
{
	public class CharacterCreatorColor : global::ScheduleOne.UI.CharacterCreator.CharacterCreatorField<global::UnityEngine.Color>
	{
		public static global::ScheduleOne.Clothing.EClothingColor[] ClothingColorsToUse;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform OptionContainer;

		[global::UnityEngine.Header("Settings")]
		public bool UseClothingColors;

		public global::System.Collections.Generic.List<global::UnityEngine.Color> Colors;

		public global::UnityEngine.GameObject OptionPrefab;

		private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> optionButtons;

		private global::UnityEngine.UI.Button selectedButton;

		protected override void Awake()
		{
		}

		public override void ApplyValue()
		{
		}

		public void OptionClicked(global::UnityEngine.Color color)
		{
		}
	}
}
