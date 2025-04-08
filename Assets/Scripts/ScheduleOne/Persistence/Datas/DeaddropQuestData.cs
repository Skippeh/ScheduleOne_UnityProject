namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class DeaddropQuestData : global::ScheduleOne.Persistence.Datas.QuestData
	{
		public string DeaddropGUID;

		public DeaddropQuestData(string guid, global::ScheduleOne.Quests.EQuestState state, bool isTracked, string title, string desc, bool isTimed, global::ScheduleOne.Persistence.Datas.GameDateTimeData expiry, global::ScheduleOne.Persistence.Datas.QuestEntryData[] entries, string deaddropGUID)
			: base(null, default(global::ScheduleOne.Quests.EQuestState), isTracked: false, null, null, expires: false, null, null)
		{
		}
	}
}
