namespace ScheduleOne.TV
{
	public class TVHomeScreen : global::ScheduleOne.TV.TVApp
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.TV.TVInterface Interface;

		public global::ScheduleOne.TV.TVApp[] Apps;

		public global::UnityEngine.RectTransform AppButtonContainer;

		public global::UnityEngine.RectTransform[] PlayerDisplays;

		public global::TMPro.TextMeshProUGUI TimeLabel;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject AppButtonPrefab;

		private bool skipExit;

		protected override void Awake()
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		protected override void ActiveMinPass()
		{
		}

		private void UpdateTimeLabel()
		{
		}

		private void AppSelected(global::ScheduleOne.TV.TVApp app)
		{
		}

		private void PlayerChange(global::ScheduleOne.PlayerScripts.Player player)
		{
		}
	}
}
