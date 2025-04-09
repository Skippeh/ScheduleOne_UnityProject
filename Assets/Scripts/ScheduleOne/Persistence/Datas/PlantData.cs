using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class PlantData : SaveData
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
