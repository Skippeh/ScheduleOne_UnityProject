using System.Collections.Generic;
using System.IO;

namespace ScheduleOne.Persistence.Loaders
{
	public class Loader
	{
		public virtual void Load(string mainPath)
		{
		}

		public bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			contents = null;
			return false;
		}

		public bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			contents = null;
			return false;
		}

		protected List<DirectoryInfo> GetDirectories(string parentPath)
		{
			return null;
		}
	}
}
