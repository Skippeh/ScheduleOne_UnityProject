namespace ScheduleOne.UI
{
	public class TextInputScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.TextInputScreen>
	{
		public delegate void OnSubmit(string text);

		public global::UnityEngine.Canvas Canvas;

		public global::TMPro.TextMeshProUGUI HeaderLabel;

		public global::TMPro.TMP_InputField InputField;

		private global::ScheduleOne.UI.TextInputScreen.OnSubmit onSubmit;

		public bool IsOpen => false;

		protected override void Awake()
		{
		}

		public void Submit()
		{
		}

		public void Cancel()
		{
		}

		private void Update()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Open(string header, string text, global::ScheduleOne.UI.TextInputScreen.OnSubmit _onSubmit, int maxChars = 10000)
		{
		}

		private void Close(bool submit)
		{
		}
	}
}
