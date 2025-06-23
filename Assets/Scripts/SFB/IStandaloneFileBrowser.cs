namespace SFB
{
	public interface IStandaloneFileBrowser
	{
		string[] OpenFilePanel(string title, string directory, global::SFB.ExtensionFilter[] extensions, bool multiselect);

		string[] OpenFolderPanel(string title, string directory, bool multiselect);

		string SaveFilePanel(string title, string directory, string defaultName, global::SFB.ExtensionFilter[] extensions);

		void OpenFilePanelAsync(string title, string directory, global::SFB.ExtensionFilter[] extensions, bool multiselect, global::System.Action<string[]> cb);

		void OpenFolderPanelAsync(string title, string directory, bool multiselect, global::System.Action<string[]> cb);

		void SaveFilePanelAsync(string title, string directory, string defaultName, global::SFB.ExtensionFilter[] extensions, global::System.Action<string> cb);
	}
}
