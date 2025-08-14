namespace ScheduleOne.UI
{
	public class CartelStatusChangePopup : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Animation Anim;

		public global::TMPro.TextMeshProUGUI OldStatusLabel;

		public global::TMPro.TextMeshProUGUI NewStatusLabel;

		public global::UnityEngine.Color UnknownColor;

		public global::UnityEngine.Color TrucedColor;

		public global::UnityEngine.Color HostileColor;

		public global::UnityEngine.Color DefeatedColor;

		private void Start()
		{
		}

		public void Show(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
		}

		private global::UnityEngine.Color GetColor(ECartelStatus status)
		{
			return default(global::UnityEngine.Color);
		}
	}
}
