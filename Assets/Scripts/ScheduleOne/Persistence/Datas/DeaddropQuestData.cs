using System;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class DeaddropQuestData : QuestData
	{
		public string DeaddropGUID;

		public DeaddropQuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, QuestEntryData[] entries, string deaddropGUID)
			: base(null, default(EQuestState), isTracked: false, null, null, expires: false, null, null)
		{
		}
	}
}
