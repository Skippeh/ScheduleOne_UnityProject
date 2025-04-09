using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	public class CharacterCreatorSlider : CharacterCreatorField<float>
	{
		[Header("References")]
		public Slider Slider;

		protected override void Awake()
		{
		}

		public override void ApplyValue()
		{
		}

		public void OnSliderChanged(float newValue)
		{
		}
	}
}
