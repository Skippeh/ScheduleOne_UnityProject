namespace ScheduleOne.AvatarFramework.Animation
{
	public class AvatarSeat : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Transform SittingPoint;

		public global::UnityEngine.Transform AccessPoint;

		public bool IsOccupied => false;

		public global::ScheduleOne.NPCs.NPC Occupant { get; protected set; }

		private void Awake()
		{
		}

		public void SetOccupant(global::ScheduleOne.NPCs.NPC npc)
		{
		}
	}
}
