namespace ScheduleOne.UI.CharacterCustomization
{
	public class BarbershopUI : global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationUI
	{
		public global::HSVPicker.ColorPicker ColorPicker;

		public global::UnityEngine.UI.Button ApplyColorButton;

		private global::UnityEngine.Color appliedColor;

		public override bool IsOptionCurrentlyApplied(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
			return false;
		}

		public override void OptionSelected(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
		}

		protected override void Update()
		{
		}

		public override void Open()
		{
		}

		public void ColorFieldChanged(global::UnityEngine.Color color)
		{
		}

		public void ApplyColorChange()
		{
		}

		public void RevertColorChange()
		{
		}
	}
}
