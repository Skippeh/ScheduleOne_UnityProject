using System;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class QuestEntryData : SaveData
	{
		public string Name;

		public EQuestState State;

		public QuestEntryData(string name, EQuestState state)
		{
		}

		public QuestEntryData()
		{
		}
	}
}
