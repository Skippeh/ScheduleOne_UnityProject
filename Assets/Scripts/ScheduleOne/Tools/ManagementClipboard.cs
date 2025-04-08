namespace ScheduleOne.Tools
{
	public class ManagementClipboard : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Tools.ManagementClipboard>
	{
		public bool IsEquipped;

		public const float OpenTime = 0.06f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform ClipboardTransform;

		public global::UnityEngine.Camera OverlayCamera;

		public global::UnityEngine.Light OverlayLight;

		public global::ScheduleOne.UI.Management.SelectionInfoUI SelectionInfo;

		[global::UnityEngine.Header("Settings")]
		public float ClosedOffset;

		public global::UnityEngine.Events.UnityEvent onClipboardEquipped;

		public global::UnityEngine.Events.UnityEvent onClipboardUnequipped;

		public global::UnityEngine.Events.UnityEvent onOpened;

		public global::UnityEngine.Events.UnityEvent onClosed;

		private global::UnityEngine.Coroutine lerpRoutine;

		private global::System.Collections.Generic.List<global::ScheduleOne.Management.IConfigurable> CurrentConfigurables;

		public bool IsOpen { get; protected set; }

		public bool StatePreserved { get; protected set; }

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exitAction)
		{
		}

		public void Open(global::System.Collections.Generic.List<global::ScheduleOne.Management.IConfigurable> selection, global::ScheduleOne.Tools.ManagementClipboard_Equippable equippable)
		{
		}

		public void Close(bool preserveState = false)
		{
		}

		private void LerpToVerticalPosition(bool open, global::System.Action callback)
		{
		}
	}
}
