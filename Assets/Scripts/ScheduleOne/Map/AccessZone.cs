using ScheduleOne.Doors;
using ScheduleOne.Misc;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Map
{
	public class AccessZone : MonoBehaviour
	{
		[Header("Settings")]
		public bool AllowExitWhenClosed;

		public bool AutoCloseDoor;

		[Header("References")]
		public DoorController[] Doors;

		public ToggleableLight[] Lights;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		public bool IsOpen { get; protected set; }

		protected virtual void Awake()
		{
		}

		public virtual void SetIsOpen(bool open)
		{
		}
	}
}
