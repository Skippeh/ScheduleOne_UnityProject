namespace SFB
{
	public class StandaloneFileBrowser
	{
		private static global::SFB.IStandaloneFileBrowser _platformWrapper;

		static StandaloneFileBrowser()
		{
		}

		public static string[] OpenFilePanel(string title, string directory, string extension, bool multiselect)
		{
			return null;
		}

		public static string[] OpenFilePanel(string title, string directory, global::SFB.ExtensionFilter[] extensions, bool multiselect)
		{
			return null;
		}

		public static void OpenFilePanelAsync(string title, string directory, string extension, bool multiselect, global::System.Action<string[]> cb)
		{
		}

		public static void OpenFilePanelAsync(string title, string directory, global::SFB.ExtensionFilter[] extensions, bool multiselect, global::System.Action<string[]> cb)
		{
		}

		public static string[] OpenFolderPanel(string title, string directory, bool multiselect)
		{
			return null;
		}

		public static void OpenFolderPanelAsync(string title, string directory, bool multiselect, global::System.Action<string[]> cb)
		{
		}

		public static string SaveFilePanel(string title, string directory, string defaultName, string extension)
		{
			return null;
		}

		public static string SaveFilePanel(string title, string directory, string defaultName, global::SFB.ExtensionFilter[] extensions)
		{
			return null;
		}

		public static void SaveFilePanelAsync(string title, string directory, string defaultName, string extension, global::System.Action<string> cb)
		{
		}

		public static void SaveFilePanelAsync(string title, string directory, string defaultName, global::SFB.ExtensionFilter[] extensions, global::System.Action<string> cb)
		{
		}
	}
}
