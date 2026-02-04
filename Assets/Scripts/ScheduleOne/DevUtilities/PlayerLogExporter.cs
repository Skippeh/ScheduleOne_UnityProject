namespace ScheduleOne.DevUtilities
{
	public class PlayerLogExporter : global::UnityEngine.MonoBehaviour
	{
		private static global::System.Action _onSuccess;

		private static global::System.Text.RegularExpressions.Regex[] ExcludedRegexes;

		public static void ExportPlayerLog(bool previous, global::System.Action onSuccess = null)
		{
		}

		private static void SavePathSelected(string savePath, bool previous)
		{
		}

		public static string FilterLog(string log)
		{
			return null;
		}

		private static string ReadFileShared(string path)
		{
			return null;
		}

		public static string GetLogPath(bool previous)
		{
			return null;
		}
	}
}
