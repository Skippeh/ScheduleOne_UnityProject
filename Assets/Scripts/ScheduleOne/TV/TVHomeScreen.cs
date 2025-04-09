using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;

namespace ScheduleOne.TV
{
	public class TVHomeScreen : TVApp
	{
		[Header("References")]
		public TVInterface Interface;

		public TVApp[] Apps;

		public RectTransform AppButtonContainer;

		public RectTransform[] PlayerDisplays;

		public TextMeshProUGUI TimeLabel;

		[Header("Prefabs")]
		public GameObject AppButtonPrefab;

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

		private void AppSelected(TVApp app)
		{
		}

		private void PlayerChange(Player player)
		{
		}
	}
}
