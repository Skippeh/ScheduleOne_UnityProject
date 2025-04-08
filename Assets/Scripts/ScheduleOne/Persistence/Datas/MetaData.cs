namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class MetaData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.DateTimeData CreationDate;

		public global::ScheduleOne.Persistence.Datas.DateTimeData LastPlayedDate;

		public string CreationVersion;

		public string LastSaveVersion;

		public bool PlayTutorial;

		public MetaData(global::ScheduleOne.Persistence.Datas.DateTimeData creationDate, global::ScheduleOne.Persistence.Datas.DateTimeData lastPlayedDate, string creationVersion, string lastSaveVersion, bool playTutorial)
		{
		}
	}
}
