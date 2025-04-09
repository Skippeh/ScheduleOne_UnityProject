using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	public class LoadRequest
	{
		public string Path;

		public Loader Loader;

		public bool IsDone { get; private set; }

		public LoadRequest(string filePath, Loader loader)
		{
		}

		public void Complete()
		{
		}
	}
}
