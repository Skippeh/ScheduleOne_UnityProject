namespace ScheduleOne.UI
{
	public class DeathScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.DeathScreen>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.CanvasGroup group;

		public global::UnityEngine.UI.Button respawnButton;

		public global::UnityEngine.UI.Button loadSaveButton;

		public global::UnityEngine.Animation Anim;

		public global::ScheduleOne.Audio.AudioSourceController Sound;

		private bool arrested;

		public bool isOpen { get; protected set; }

		protected override void Awake()
		{
		}

		private void RespawnClicked()
		{
		}

		private void LoadSaveClicked()
		{
		}

		public void Open()
		{
		}

		private bool CanRespawn()
		{
			return false;
		}

		public void Close()
		{
		}
	}
}
