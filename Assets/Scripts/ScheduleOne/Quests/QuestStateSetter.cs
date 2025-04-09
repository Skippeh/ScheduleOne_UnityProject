using System;

namespace ScheduleOne.Quests
{
	[Serializable]
	public class QuestStateSetter
	{
		public string QuestName;

		public bool SetQuestState;

		public QuestManager.EQuestAction QuestState;

		public bool SetQuestEntryState;

		public int QuestEntryIndex;

		public EQuestState QuestEntryState;

		public void Execute()
		{
		}
	}
}
