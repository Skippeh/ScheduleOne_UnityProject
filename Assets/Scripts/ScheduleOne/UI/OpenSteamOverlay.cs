using UnityEngine;

namespace ScheduleOne.UI
{
	public class OpenSteamOverlay : MonoBehaviour
	{
		public enum EType
		{
			Store = 0,
			CustomLink = 1
		}

		public const uint APP_ID = 3164500u;

		public EType Type;

		public string CustomLink;

		public void OpenOverlay()
		{
		}
	}
}
