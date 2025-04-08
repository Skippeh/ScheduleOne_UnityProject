namespace ScheduleOne.UI.Multiplayer
{
	public class LobbyInterface : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.UI.Multiplayer.LobbyInterface>
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Networking.Lobby Lobby;

		public global::UnityEngine.Canvas Canvas;

		public global::TMPro.TextMeshProUGUI LobbyTitle;

		public global::UnityEngine.RectTransform[] PlayerSlots;

		public global::UnityEngine.UI.Button InviteButton;

		public global::UnityEngine.UI.Button LeaveButton;

		public global::UnityEngine.GameObject InviteHint;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void LeaveClicked()
		{
		}

		public void InviteClicked()
		{
		}

		private void UpdateButtons()
		{
		}

		private void UpdatePlayers()
		{
		}

		public void SetPlayer(int index, global::Steamworks.CSteamID player)
		{
		}

		public void ClearPlayer(int index)
		{
		}

		private global::UnityEngine.Texture2D GetAvatar(global::Steamworks.CSteamID user)
		{
			return null;
		}
	}
}
