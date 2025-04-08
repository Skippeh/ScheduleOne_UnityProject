namespace ScheduleOne.Variables
{
	[global::System.Serializable]
	public class QuestCondition
	{
		public bool CheckQuestState;

		public string QuestName;

		public global::ScheduleOne.Quests.EQuestState QuestState;

		public bool CheckQuestEntryState;

		public int QuestEntryIndex;

		public global::ScheduleOne.Quests.EQuestState QuestEntryState;

		public bool Evaluate()
		{
			return false;
		}
	}
}
