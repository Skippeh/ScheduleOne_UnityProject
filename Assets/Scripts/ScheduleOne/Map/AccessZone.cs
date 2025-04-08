namespace ScheduleOne.Map
{
	public class AccessZone : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public bool AllowExitWhenClosed;

		public bool AutoCloseDoor;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Doors.DoorController[] Doors;

		public global::ScheduleOne.Misc.ToggleableLight[] Lights;

		public global::UnityEngine.Events.UnityEvent onOpen;

		public global::UnityEngine.Events.UnityEvent onClose;

		public bool IsOpen { get; protected set; }

		protected virtual void Awake()
		{
		}

		public virtual void SetIsOpen(bool open)
		{
		}
	}
}
