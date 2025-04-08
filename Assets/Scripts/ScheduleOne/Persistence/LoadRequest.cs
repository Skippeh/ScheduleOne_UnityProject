namespace ScheduleOne.Persistence
{
	public class LoadRequest
	{
		public string Path;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader;

		public bool IsDone { get; private set; }

		public LoadRequest(string filePath, global::ScheduleOne.Persistence.Loaders.Loader loader)
		{
		}

		public void Complete()
		{
		}
	}
}
