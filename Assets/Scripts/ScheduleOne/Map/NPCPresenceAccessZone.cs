namespace ScheduleOne.Map
{
	public class NPCPresenceAccessZone : global::ScheduleOne.Map.AccessZone
	{
		public const float CooldownTime = 0.5f;

		public global::UnityEngine.Collider DetectionZone;

		public global::ScheduleOne.NPCs.NPC TargetNPC;

		private float timeSinceNPCSensed;

		protected override void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void MinPass()
		{
		}
	}
}
