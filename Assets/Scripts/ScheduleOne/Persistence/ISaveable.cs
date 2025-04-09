using System.Collections.Generic;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	public interface ISaveable
	{
		string SaveFolderName { get; }

		string SaveFileName { get; }

		Loader Loader { get; }

		bool ShouldSaveUnderFolder { get; }

		List<string> LocalExtraFiles { get; set; }

		List<string> LocalExtraFolders { get; set; }

		bool HasChanged { get; set; }

		void InitializeSaveable();

		string GetSaveString();

		string Save(string parentFolderPath)
		{
			return null;
		}

		void WriteBaseData(string parentFolderPath, string saveString)
		{
		}

		string GetLocalPath(out bool isFolder)
		{
			isFolder = default(bool);
			return null;
		}

		void CompleteSave(string parentFolderPath, bool writeDataFile)
		{
		}

		List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		string GetContainerFolder(string parentFolderPath)
		{
			return null;
		}

		string WriteSubfile(string parentPath, string localPath_NoExtensions, string contents)
		{
			return null;
		}

		string WriteFolder(string parentPath, string localPath_NoExtensions)
		{
			return null;
		}

		bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			contents = null;
			return false;
		}

		bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			contents = null;
			return false;
		}
	}
}
