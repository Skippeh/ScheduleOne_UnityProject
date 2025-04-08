namespace ScheduleOne.Persistence.Datas
{
	public class GameData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string OrganisationName;

		public int Seed;

		public global::ScheduleOne.DevUtilities.GameSettings Settings;

		public GameData(string organisationName, int seed, global::ScheduleOne.DevUtilities.GameSettings settings)
		{
		}

		public GameData()
		{
		}
	}
}
