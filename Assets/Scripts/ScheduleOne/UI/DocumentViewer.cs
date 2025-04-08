namespace ScheduleOne.UI
{
	public class DocumentViewer : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.DocumentViewer>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform[] Documents;

		public global::UnityEngine.Events.UnityEvent onOpen;

		public bool IsOpen { get; protected set; }

		protected override void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Open(string documentName)
		{
		}

		public void Close()
		{
		}
	}
}
