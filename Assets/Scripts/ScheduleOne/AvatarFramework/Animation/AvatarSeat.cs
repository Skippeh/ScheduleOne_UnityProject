using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	public class AvatarSeat : MonoBehaviour
	{
		public Transform SittingPoint;

		public Transform AccessPoint;

		public bool IsOccupied => false;

		public NPC Occupant { get; protected set; }

		private void Awake()
		{
		}

		public void SetOccupant(NPC npc)
		{
		}
	}
}
