namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class QuestData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string GUID;

		public global::ScheduleOne.Quests.EQuestState State;

		public bool IsTracked;

		public string Title;

		public string Description;

		public bool Expires;

		public global::ScheduleOne.Persistence.Datas.GameDateTimeData ExpiryDate;

		public global::ScheduleOne.Persistence.Datas.QuestEntryData[] Entries;

		public QuestData(string guid, global::ScheduleOne.Quests.EQuestState state, bool isTracked, string title, string desc, bool expires, global::ScheduleOne.Persistence.Datas.GameDateTimeData expiry, global::ScheduleOne.Persistence.Datas.QuestEntryData[] entries)
		{
		}
	}
}
