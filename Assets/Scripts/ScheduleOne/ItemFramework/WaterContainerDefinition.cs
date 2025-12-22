namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "WaterContainerDefinition", menuName = "ScriptableObjects/Item Definitions/WaterContainerDefinition", order = 1)]
	public class WaterContainerDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		[global::UnityEngine.SerializeField]
		public float Capacity;

		[global::UnityEngine.SerializeField]
		public global::ScheduleOne.Tools.FillableWaterContainer FillablePrefab;

		public override void ValidateDefinition()
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
