using ScheduleOne.DevUtilities;
using ScheduleOne.Networking;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Multiplayer
{
	public class LobbyInterface : PersistentSingleton<LobbyInterface>
	{
		[Header("References")]
		public Lobby Lobby;

		public Canvas Canvas;

		public TextMeshProUGUI LobbyTitle;

		public RectTransform[] PlayerSlots;

		public Button InviteButton;

		public Button LeaveButton;

		public GameObject InviteHint;

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

		public void SetPlayer(int index, CSteamID player)
		{
		}

		public void ClearPlayer(int index)
		{
		}

		private Texture2D GetAvatar(CSteamID user)
		{
			return null;
		}
	}
}
