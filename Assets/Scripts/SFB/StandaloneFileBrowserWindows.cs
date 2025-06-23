namespace SFB
{
	public class StandaloneFileBrowserWindows : global::SFB.IStandaloneFileBrowser
	{
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern global::System.IntPtr GetActiveWindow();

		public string[] OpenFilePanel(string title, string directory, global::SFB.ExtensionFilter[] extensions, bool multiselect)
		{
			return null;
		}

		public void OpenFilePanelAsync(string title, string directory, global::SFB.ExtensionFilter[] extensions, bool multiselect, global::System.Action<string[]> cb)
		{
		}

		public string[] OpenFolderPanel(string title, string directory, bool multiselect)
		{
			return null;
		}

		public void OpenFolderPanelAsync(string title, string directory, bool multiselect, global::System.Action<string[]> cb)
		{
		}

		public string SaveFilePanel(string title, string directory, string defaultName, global::SFB.ExtensionFilter[] extensions)
		{
			return null;
		}

		public void SaveFilePanelAsync(string title, string directory, string defaultName, global::SFB.ExtensionFilter[] extensions, global::System.Action<string> cb)
		{
		}

		private static string GetFilterFromFileExtensionList(global::SFB.ExtensionFilter[] extensions)
		{
			return null;
		}

		private static string GetDirectoryPath(string directory)
		{
			return null;
		}
	}
}
