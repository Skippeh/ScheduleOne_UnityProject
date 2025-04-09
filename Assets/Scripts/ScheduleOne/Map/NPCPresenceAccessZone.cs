using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class NPCPresenceAccessZone : AccessZone
	{
		public const float CooldownTime = 0.5f;

		public Collider DetectionZone;

		public NPC TargetNPC;

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
