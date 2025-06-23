namespace ScheduleOne.Persistence.Datas
{
	public class QuestManagerData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.QuestData[] Quests;

		public global::ScheduleOne.Persistence.Datas.ContractData[] Contracts;

		public global::ScheduleOne.Persistence.Datas.DeaddropQuestData[] DeaddropQuests;

		public QuestManagerData(global::ScheduleOne.Persistence.Datas.QuestData[] quests, global::ScheduleOne.Persistence.Datas.ContractData[] contracts, global::ScheduleOne.Persistence.Datas.DeaddropQuestData[] deaddropQuests)
		{
		}
	}
}
