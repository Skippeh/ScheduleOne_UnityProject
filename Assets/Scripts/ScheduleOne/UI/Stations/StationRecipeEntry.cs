using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	public class StationRecipeEntry : MonoBehaviour
	{
		public static Color ValidColor;

		public static Color InvalidColor;

		public Button Button;

		public Image Icon;

		public TextMeshProUGUI TitleLabel;

		public TextMeshProUGUI CookingTimeLabel;

		public RectTransform[] IngredientRects;

		private TextMeshProUGUI[] IngredientQuantities;

		public bool IsValid { get; private set; }

		public StationRecipe Recipe { get; private set; }

		public void AssignRecipe(StationRecipe recipe)
		{
		}

		public void RefreshValidity(List<ItemInstance> ingredients)
		{
		}

		public float GetIngredientsMatchDelta(List<ItemInstance> ingredients)
		{
			return 0f;
		}
	}
}
