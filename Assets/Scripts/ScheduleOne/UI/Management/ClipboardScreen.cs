namespace ScheduleOne.UI.Management
{
	public class ClipboardScreen : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Container;

		[global::UnityEngine.Header("Settings")]
		public float ClosedOffset;

		public bool OpenOnStart;

		public bool UseExitListener;

		public int ExitActionPriority;

		private global::UnityEngine.Coroutine lerpRoutine;

		public bool IsOpen { get; protected set; }

		protected virtual void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exitAction)
		{
		}

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}

		private void Lerp(bool open, global::System.Action callback)
		{
		}
	}
}
