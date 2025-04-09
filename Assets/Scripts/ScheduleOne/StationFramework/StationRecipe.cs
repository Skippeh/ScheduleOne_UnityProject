using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "StationRecipe", menuName = "StationFramework/StationRecipe", order = 1)]
	public class StationRecipe : ScriptableObject
	{
		public enum EQualityCalculationMethod
		{
			Additive = 0
		}

		[Serializable]
		public class ItemQuantity
		{
			public ItemDefinition Item;

			public int Quantity;
		}

		[Serializable]
		public class IngredientQuantity
		{
			public List<ItemDefinition> Items;

			public int Quantity;

			public ItemDefinition Item => null;
		}

		[HideInInspector]
		public bool IsDiscovered;

		public string RecipeTitle;

		public bool Unlocked;

		public List<IngredientQuantity> Ingredients;

		public ItemQuantity Product;

		public Color FinalLiquidColor;

		[Tooltip("The time it takes to cook this recipe in minutes")]
		public int CookTime_Mins;

		[Tooltip("The temperature at which this recipe should be cooked")]
		[Range(0f, 500f)]
		public float CookTemperature;

		[Range(0f, 100f)]
		public float CookTemperatureTolerance;

		public EQualityCalculationMethod QualityCalculationMethod;

		public float CookTemperatureLowerBound => 0f;

		public float CookTemperatureUpperBound => 0f;

		public string RecipeID => null;

		public StorableItemInstance GetProductInstance(List<ItemInstance> ingredients)
		{
			return null;
		}

		public StorableItemInstance GetProductInstance(EQuality quality)
		{
			return null;
		}

		public bool DoIngredientsSuffice(List<ItemInstance> ingredients)
		{
			return false;
		}

		public EQuality CalculateQuality(List<ItemInstance> ingredients)
		{
			return default(EQuality);
		}
	}
}
