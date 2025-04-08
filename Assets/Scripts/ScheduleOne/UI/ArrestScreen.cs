namespace ScheduleOne.UI
{
	public class ArrestScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.ArrestScreen>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas canvas;

		public global::UnityEngine.CanvasGroup group;

		public global::ScheduleOne.Audio.AudioSourceController Sound;

		public global::UnityEngine.Animation Anim;

		public bool isOpen { get; protected set; }

		protected override void Awake()
		{
		}

		private void Continue()
		{
		}

		private void LoadSaveClicked()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}
	}
}
