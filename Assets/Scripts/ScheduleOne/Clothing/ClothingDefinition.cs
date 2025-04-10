namespace ScheduleOne.Clothing
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "ClothingDefinition", menuName = "ScriptableObjects/ClothingDefinition", order = 1)]
	public class ClothingDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		public global::ScheduleOne.Clothing.EClothingSlot Slot;

		public global::ScheduleOne.Clothing.EClothingApplicationType ApplicationType;

		public string ClothingAssetPath;

		public bool Colorable;

		public global::ScheduleOne.Clothing.EClothingColor DefaultColor;

		public global::System.Collections.Generic.List<global::ScheduleOne.Clothing.EClothingSlot> SlotsToBlock;

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
