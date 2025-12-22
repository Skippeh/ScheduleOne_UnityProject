namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ShroomColonyData
	{
		public string MushroomSpawnID;

		public float GrowthProgress;

		public float Quality;

		public int[] ActiveMushroomAlignmentIndices;

		public ShroomColonyData(string mushroomSpawnID, float growthProgress, float quality, int[] activeMushroomAlignmentIndices)
		{
		}
	}
}
