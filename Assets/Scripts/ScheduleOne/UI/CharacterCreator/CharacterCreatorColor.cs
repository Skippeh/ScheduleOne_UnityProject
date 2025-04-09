using System.Collections.Generic;
using ScheduleOne.Clothing;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	public class CharacterCreatorColor : CharacterCreatorField<Color>
	{
		public static EClothingColor[] ClothingColorsToUse;

		[Header("References")]
		public RectTransform OptionContainer;

		[Header("Settings")]
		public bool UseClothingColors;

		public List<Color> Colors;

		public GameObject OptionPrefab;

		private List<Button> optionButtons;

		private Button selectedButton;

		protected override void Awake()
		{
		}

		public override void ApplyValue()
		{
		}

		public void OptionClicked(Color color)
		{
		}
	}
}
