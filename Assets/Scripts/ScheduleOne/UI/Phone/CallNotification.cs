namespace ScheduleOne.UI.Phone
{
	public class CallNotification : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Phone.CallNotification>
	{
		public const float TIME_PER_CHAR = 0.015f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.UI.Image ProfilePicture;

		public global::UnityEngine.CanvasGroup Group;

		private global::UnityEngine.Coroutine slideRoutine;

		public global::ScheduleOne.ScriptableObjects.PhoneCallData ActiveCallData { get; private set; }

		public bool IsOpen { get; protected set; }

		protected override void Awake()
		{
		}

		public void SetIsOpen(bool visible, global::ScheduleOne.ScriptableObjects.CallerID caller)
		{
		}
	}
}
