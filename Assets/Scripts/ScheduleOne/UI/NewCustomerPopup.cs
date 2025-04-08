namespace ScheduleOne.UI
{
	public class NewCustomerPopup : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.NewCustomerPopup>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.CanvasGroup Group;

		public global::UnityEngine.Animation Anim;

		public global::TMPro.TextMeshProUGUI Title;

		public global::UnityEngine.RectTransform[] Entries;

		public global::ScheduleOne.Audio.AudioSourceController SoundEffect;

		private global::UnityEngine.Coroutine routine;

		public bool IsPlaying { get; protected set; }

		protected override void Awake()
		{
		}

		public void PlayPopup(global::ScheduleOne.Economy.Customer customer)
		{
		}

		private void DisableEntries()
		{
		}
	}
}
