using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	public class GenericUIScreen : MonoBehaviour
	{
		[Header("Settings")]
		public string Name;

		public bool UseExitActions;

		public int ExitActionPriority;

		public bool CanExitWithRightClick;

		public bool ReenableControlsOnClose;

		public bool ReenableInventoryOnClose;

		public bool ReenableEquippingOnClose;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		public bool IsOpen { get; private set; }

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void Exit(ExitAction action)
		{
		}
	}
}
