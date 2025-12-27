namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class PlantData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string SeedID;

		public float GrowthProgress;

		public int[] ActiveBuds;

		public PlantData(string seedID, float growthProgress, int[] activeBuds)
		{
		}
	}
}
