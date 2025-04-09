using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class NotificationsManager : Singleton<NotificationsManager>
	{
		public const int MAX_NOTIFICATIONS = 6;

		[Header("References")]
		public RectTransform EntryContainer;

		public AudioSourceController Sound;

		[Header("Prefab")]
		public GameObject NotificationPrefab;

		private Dictionary<RectTransform, Coroutine> coroutines;

		private List<RectTransform> entries;

		private void Update()
		{
		}

		public void SendNotification(string title, string subtitle, Sprite icon, float duration = 5f, bool playSound = true)
		{
		}
	}
}
