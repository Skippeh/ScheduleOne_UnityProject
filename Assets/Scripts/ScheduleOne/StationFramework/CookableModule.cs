using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	public class CookableModule : ItemModule
	{
		public enum ECookableType
		{
			Liquid = 0,
			Solid = 1
		}

		[Header("Cook Settings")]
		public int CookTime;

		public ECookableType CookType;

		[Header("Product Settings")]
		public StorableItemDefinition Product;

		public int ProductQuantity;

		public Rigidbody ProductShardPrefab;

		[Header("Appearance")]
		public Color LiquidColor;

		public Color SolidColor;
	}
}
