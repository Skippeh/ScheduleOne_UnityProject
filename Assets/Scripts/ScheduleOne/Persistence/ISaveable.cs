namespace ScheduleOne.Persistence
{
	public interface ISaveable
	{
		string SaveFolderName { get; }

		string SaveFileName { get; }

		global::ScheduleOne.Persistence.Loaders.Loader Loader { get; }

		bool ShouldSaveUnderFolder { get; }

		global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

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

		global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
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
