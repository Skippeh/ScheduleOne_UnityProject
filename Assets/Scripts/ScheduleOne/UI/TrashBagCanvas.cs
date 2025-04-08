namespace ScheduleOne.UI
{
	public class TrashBagCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.TrashBagCanvas>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::ScheduleOne.UI.Input.InputPrompt InputPrompt;

		public bool IsOpen { get; private set; }

		public void Open()
		{
		}

		public void Close()
		{
		}
	}
}
