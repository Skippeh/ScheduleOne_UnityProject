namespace ScheduleOne.StationFramework
{
	public class CookableModule : global::ScheduleOne.StationFramework.ItemModule
	{
		public enum ECookableType
		{
			Liquid = 0,
			Solid = 1
		}

		[global::UnityEngine.Header("Cook Settings")]
		public int CookTime;

		public global::ScheduleOne.StationFramework.CookableModule.ECookableType CookType;

		[global::UnityEngine.Header("Product Settings")]
		public global::ScheduleOne.ItemFramework.StorableItemDefinition Product;

		public int ProductQuantity;

		public global::UnityEngine.Rigidbody ProductShardPrefab;

		[global::UnityEngine.Header("Appearance")]
		public global::UnityEngine.Color LiquidColor;

		public global::UnityEngine.Color SolidColor;
	}
}
