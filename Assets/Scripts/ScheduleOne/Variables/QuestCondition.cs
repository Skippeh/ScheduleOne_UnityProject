using System;
using ScheduleOne.Quests;

namespace ScheduleOne.Variables
{
	[Serializable]
	public class QuestCondition
	{
		public bool CheckQuestState;

		public string QuestName;

		public EQuestState QuestState;

		public bool CheckQuestEntryState;

		public int QuestEntryIndex;

		public EQuestState QuestEntryState;

		public bool Evaluate()
		{
			return false;
		}
	}
}
