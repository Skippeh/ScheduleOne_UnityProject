namespace ScheduleOne.Growing
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "SeedDefinition", menuName = "ScriptableObjects/Item Definitions/SeedDefinition", order = 1)]
	public class SeedDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		public global::ScheduleOne.Growing.FunctionalSeed FunctionSeedPrefab;

		public global::ScheduleOne.Growing.Plant PlantPrefab;
	}
}
