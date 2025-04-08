namespace ScheduleOne.UI.Stations
{
	public class StationRecipeEntry : global::UnityEngine.MonoBehaviour
	{
		public static global::UnityEngine.Color ValidColor;

		public static global::UnityEngine.Color InvalidColor;

		public global::UnityEngine.UI.Button Button;

		public global::UnityEngine.UI.Image Icon;

		public global::TMPro.TextMeshProUGUI TitleLabel;

		public global::TMPro.TextMeshProUGUI CookingTimeLabel;

		public global::UnityEngine.RectTransform[] IngredientRects;

		private global::TMPro.TextMeshProUGUI[] IngredientQuantities;

		public bool IsValid { get; private set; }

		public global::ScheduleOne.StationFramework.StationRecipe Recipe { get; private set; }

		public void AssignRecipe(global::ScheduleOne.StationFramework.StationRecipe recipe)
		{
		}

		public void RefreshValidity(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> ingredients)
		{
		}

		public float GetIngredientsMatchDelta(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> ingredients)
		{
			return 0f;
		}
	}
}
