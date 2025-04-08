namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class QuestEntryData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string Name;

		public global::ScheduleOne.Quests.EQuestState State;

		public QuestEntryData(string name, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		public QuestEntryData()
		{
		}
	}
}
