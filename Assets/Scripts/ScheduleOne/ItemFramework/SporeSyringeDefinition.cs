namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "SporeSyringeDefinition", menuName = "ScriptableObjects/Item Definitions/SporeSyringeDefinition", order = 1)]
	public class SporeSyringeDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.ItemFramework.ShroomSpawnDefinition SpawnDefinition { get; private set; }
	}
}
