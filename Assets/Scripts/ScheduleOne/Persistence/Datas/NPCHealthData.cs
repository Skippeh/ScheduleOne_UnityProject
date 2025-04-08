namespace ScheduleOne.Persistence.Datas
{
	public class NPCHealthData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public float Health;

		public bool IsDead;

		public int DaysPassedSinceDeath;

		public NPCHealthData(float health, bool isDead, int daysPassedSinceDeath)
		{
		}
	}
}
