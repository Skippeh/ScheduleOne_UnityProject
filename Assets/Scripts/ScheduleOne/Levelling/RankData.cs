namespace ScheduleOne.Levelling
{
	public class RankData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public int Rank;

		public int Tier;

		public int XP;

		public int TotalXP;

		public global::System.Collections.Generic.List<global::ScheduleOne.Map.EMapRegion> UnlockedRegions;

		public RankData(int rank, int tier, int xp, int totalXP, global::System.Collections.Generic.List<global::ScheduleOne.Map.EMapRegion> unlockedRegions)
		{
		}
	}
}
