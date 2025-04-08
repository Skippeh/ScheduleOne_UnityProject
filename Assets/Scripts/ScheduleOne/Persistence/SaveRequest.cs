namespace ScheduleOne.Persistence
{
	public class SaveRequest
	{
		public global::ScheduleOne.Persistence.ISaveable Saveable;

		public string ParentFolderPath;

		public string SaveString { get; private set; }

		public SaveRequest(global::ScheduleOne.Persistence.ISaveable saveable, string parentFolderPath)
		{
		}

		public void Complete()
		{
		}
	}
}
