namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class PlantData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string SeedID;

		public float GrowthProgress;

		public float YieldLevel;

		public float QualityLevel;

		public int[] ActiveBuds;

		public PlantData(string seedID, float growthProgress, float yieldLevel, float qualityLevel, int[] activeBuds)
		{
		}
	}
}
