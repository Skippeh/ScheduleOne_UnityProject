namespace ScheduleOne.UI
{
	public class ConsoleUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas canvas;

		public global::TMPro.TMP_InputField InputField;

		public global::UnityEngine.GameObject Container;

		private static global::System.Collections.Generic.List<string> _commandHistory;

		private int _currentCommandIndex;

		public bool IS_CONSOLE_ENABLED => false;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateCommandHistory()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exitAction)
		{
		}

		public void SetIsOpen(bool open)
		{
		}

		public void Submit(string val)
		{
		}
	}
}
