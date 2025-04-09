using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	public class CallNotification : Singleton<CallNotification>
	{
		public const float TIME_PER_CHAR = 0.015f;

		[Header("References")]
		public RectTransform Container;

		public Image ProfilePicture;

		public CanvasGroup Group;

		private Coroutine slideRoutine;

		public PhoneCallData ActiveCallData { get; private set; }

		public bool IsOpen { get; protected set; }

		protected override void Awake()
		{
		}

		public void SetIsOpen(bool visible, CallerID caller)
		{
		}
	}
}
