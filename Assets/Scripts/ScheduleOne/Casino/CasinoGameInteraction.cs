using System;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	public class CasinoGameInteraction : MonoBehaviour
	{
		public string GameName;

		[Header("References")]
		public CasinoGamePlayers Players;

		public InteractableObject IntObj;

		public Action<Player> onLocalPlayerRequestJoin;

		private void Awake()
		{
		}

		private void Hovered()
		{
		}

		private void Interacted()
		{
		}
	}
}
