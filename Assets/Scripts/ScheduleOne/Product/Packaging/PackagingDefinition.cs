namespace ScheduleOne.Product.Packaging
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "PackagingDefinition", menuName = "ScriptableObjects/Item Definitions/PackagingDefinition", order = 1)]
	public class PackagingDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		public int Quantity;

		public global::ScheduleOne.Product.Packaging.EStealthLevel StealthLevel;

		public global::ScheduleOne.Packaging.FunctionalPackaging FunctionalPackaging;

		public global::ScheduleOne.Equipping.Equippable Equippable_Filled;

		public global::ScheduleOne.Storage.StoredItem StoredItem_Filled;
	}
}
