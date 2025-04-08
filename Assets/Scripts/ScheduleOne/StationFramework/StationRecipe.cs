namespace ScheduleOne.StationFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "StationRecipe", menuName = "StationFramework/StationRecipe", order = 1)]
	public class StationRecipe : global::UnityEngine.ScriptableObject
	{
		public enum EQualityCalculationMethod
		{
			Additive = 0
		}

		[global::System.Serializable]
		public class ItemQuantity
		{
			public global::ScheduleOne.ItemFramework.ItemDefinition Item;

			public int Quantity;
		}

		[global::System.Serializable]
		public class IngredientQuantity
		{
			public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemDefinition> Items;

			public int Quantity;

			public global::ScheduleOne.ItemFramework.ItemDefinition Item => null;
		}

		[global::UnityEngine.HideInInspector]
		public bool IsDiscovered;

		public string RecipeTitle;

		public bool Unlocked;

		public global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationRecipe.IngredientQuantity> Ingredients;

		public global::ScheduleOne.StationFramework.StationRecipe.ItemQuantity Product;

		public global::UnityEngine.Color FinalLiquidColor;

		[global::UnityEngine.Tooltip("The time it takes to cook this recipe in minutes")]
		public int CookTime_Mins;

		[global::UnityEngine.Tooltip("The temperature at which this recipe should be cooked")]
		[global::UnityEngine.Range(0f, 500f)]
		public float CookTemperature;

		[global::UnityEngine.Range(0f, 100f)]
		public float CookTemperatureTolerance;

		public global::ScheduleOne.StationFramework.StationRecipe.EQualityCalculationMethod QualityCalculationMethod;

		public float CookTemperatureLowerBound => 0f;

		public float CookTemperatureUpperBound => 0f;

		public string RecipeID => null;

		public global::ScheduleOne.Storage.StorableItemInstance GetProductInstance(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> ingredients)
		{
			return null;
		}

		public global::ScheduleOne.Storage.StorableItemInstance GetProductInstance(global::ScheduleOne.ItemFramework.EQuality quality)
		{
			return null;
		}

		public bool DoIngredientsSuffice(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> ingredients)
		{
			return false;
		}

		public global::ScheduleOne.ItemFramework.EQuality CalculateQuality(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> ingredients)
		{
			return default(global::ScheduleOne.ItemFramework.EQuality);
		}
	}
}
