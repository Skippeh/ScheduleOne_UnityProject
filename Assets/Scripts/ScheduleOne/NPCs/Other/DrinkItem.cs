using ScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	public class DrinkItem : MonoBehaviour
	{
		public NPC Npc;

		public AvatarEquippable DrinkPrefab;

		public bool active { get; protected set; }

		private void Awake()
		{
		}

		public void Begin()
		{
		}

		public void End()
		{
		}
	}
}
