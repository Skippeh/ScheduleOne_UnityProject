using System;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class QuestData : SaveData
	{
		public string GUID;

		public EQuestState State;

		public bool IsTracked;

		public string Title;

		public string Description;

		public bool Expires;

		public GameDateTimeData ExpiryDate;

		public QuestEntryData[] Entries;

		public QuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool expires, GameDateTimeData expiry, QuestEntryData[] entries)
		{
		}
	}
}
