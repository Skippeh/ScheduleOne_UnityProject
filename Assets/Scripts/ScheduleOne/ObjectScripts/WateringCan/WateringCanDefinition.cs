namespace ScheduleOne.ObjectScripts.WateringCan
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "WateringCanDefinition", menuName = "ScriptableObjects/Item Definitions/WateringCanDefinition", order = 1)]
	public class WateringCanDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		public const float Capacity = 15f;

		public global::UnityEngine.GameObject FunctionalWateringCanPrefab;

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
