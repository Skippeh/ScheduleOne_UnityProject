using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class MetaData : SaveData
	{
		public DateTimeData CreationDate;

		public DateTimeData LastPlayedDate;

		public string CreationVersion;

		public string LastSaveVersion;

		public bool PlayTutorial;

		public MetaData(DateTimeData creationDate, DateTimeData lastPlayedDate, string creationVersion, string lastSaveVersion, bool playTutorial)
		{
		}
	}
}
