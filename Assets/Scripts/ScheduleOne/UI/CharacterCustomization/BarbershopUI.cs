using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	public class BarbershopUI : CharacterCustomizationUI
	{
		public HSVPicker.ColorPicker ColorPicker;

		public Button ApplyColorButton;

		private Color appliedColor;

		public override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			return false;
		}

		public override void OptionSelected(CharacterCustomizationOption option)
		{
		}

		protected override void Update()
		{
		}

		public override void Open()
		{
		}

		public void ColorFieldChanged(Color color)
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
