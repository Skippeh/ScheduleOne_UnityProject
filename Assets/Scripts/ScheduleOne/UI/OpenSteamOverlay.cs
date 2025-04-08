namespace ScheduleOne.UI
{
	public class OpenSteamOverlay : global::UnityEngine.MonoBehaviour
	{
		public enum EType
		{
			Store = 0,
			CustomLink = 1
		}

		public const uint APP_ID = 3164500u;

		public global::ScheduleOne.UI.OpenSteamOverlay.EType Type;

		public string CustomLink;

		public void OpenOverlay()
		{
		}
	}
}
