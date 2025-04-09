using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class ManagementMode : Singleton<ManagementMode>
	{
		[Header("References")]
		public InputPrompt ManagementModeInputPrompt;

		[Header("UI References")]
		public Canvas Canvas;

		public UnityEvent OnEnterManagementMode;

		public UnityEvent onExitManagementMode;

		public ScheduleOne.Property.Property CurrentProperty { get; private set; }

		public bool isActive => false;

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateInput()
		{
		}

		private void Exit(ExitAction exitAction)
		{
		}

		public void EnterManagementMode(ScheduleOne.Property.Property property)
		{
		}

		public void ExitManagementMode()
		{
		}

		public static bool CanEnterManagementMode()
		{
			return false;
		}

		public static bool CanExitManagementMode()
		{
			return false;
		}
	}
}
