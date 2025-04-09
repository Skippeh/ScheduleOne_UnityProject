namespace ScheduleOne.Persistence
{
	public class SaveRequest
	{
		public ISaveable Saveable;

		public string ParentFolderPath;

		public string SaveString { get; private set; }

		public SaveRequest(ISaveable saveable, string parentFolderPath)
		{
		}

		public void Complete()
		{
		}
	}
}
