namespace ScheduleOne.Quests
{
	[global::System.Serializable]
	public class QuestStateSetter
	{
		public string QuestName;

		public bool SetQuestState;

		public global::ScheduleOne.Quests.QuestManager.EQuestAction QuestState;

		public bool SetQuestEntryState;

		public int QuestEntryIndex;

		public global::ScheduleOne.Quests.EQuestState QuestEntryState;

		public void Execute()
		{
		}
	}
}
