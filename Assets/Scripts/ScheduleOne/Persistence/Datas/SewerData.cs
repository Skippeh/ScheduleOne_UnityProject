namespace ScheduleOne.Persistence.Datas
{
	public class SewerData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public bool IsSewerUnlocked;

		public bool IsRandomWorldKeyCollected;

		public int RandomSewerKeyLocationIndex;

		public bool HasSewerKingBeenDefeated;

		public int HoursSinceLastSewerGoblinAppearance;

		public int RandomKeyPossessorIndex;

		public bool RandomKeyPossessorSet;

		public SewerData(bool isSewerUnlocked, bool isRandomWorldKeyCollected, int randomSewerKeyLocationIndex, bool hasSewerKingBeenDefeated, int hoursSinceLastSewerGoblinAppearance, int randomKeyPossessorIndex)
		{
		}
	}
}
