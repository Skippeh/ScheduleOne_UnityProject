namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "ShroomSpawnDefinition", menuName = "ScriptableObjects/Item Definitions/ShroomSpawnDefinition", order = 1)]
	public class ShroomSpawnDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.Growing.ShroomColony ColonyPrefab { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.Product.ShroomDefinition Shroom { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.PlayerTasks.SpawnChunk ChunkPrefab { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Rendering.Universal.DecalProjector MixTaskProjectorPrefab { get; private set; }

		public override void ValidateDefinition()
		{
		}
	}
}
