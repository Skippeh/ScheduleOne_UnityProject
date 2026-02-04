namespace ScheduleOne.TV
{
	public class TVInterface : global::UnityEngine.MonoBehaviour
	{
		public const float OPEN_TIME = 0.15f;

		public const float FOV = 60f;

		public global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> Players;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.Transform CameraPosition;

		public global::ScheduleOne.TV.TVHomeScreen HomeScreen;

		public global::TMPro.TextMeshPro TimeLabel;

		public global::TMPro.TextMeshPro Daylabel;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onPlayerAdded;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onPlayerRemoved;

		public bool IsOpen { get; private set; }

		public void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void MinPass()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public bool CanOpen()
		{
			return false;
		}

		public void AddPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public void RemovePlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}
	}
}
