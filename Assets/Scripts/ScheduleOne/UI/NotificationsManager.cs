namespace ScheduleOne.UI
{
	public class NotificationsManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.NotificationsManager>
	{
		public const int MAX_NOTIFICATIONS = 6;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform EntryContainer;

		public global::ScheduleOne.Audio.AudioSourceController Sound;

		[global::UnityEngine.Header("Prefab")]
		public global::UnityEngine.GameObject NotificationPrefab;

		private global::System.Collections.Generic.Dictionary<global::UnityEngine.RectTransform, global::UnityEngine.Coroutine> coroutines;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> entries;

		private void Update()
		{
		}

		public void SendNotification(string title, string subtitle, global::UnityEngine.Sprite icon, float duration = 5f, bool playSound = true)
		{
		}
	}
}
