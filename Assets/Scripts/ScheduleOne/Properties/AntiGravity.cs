using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	[CreateAssetMenu(fileName = "AntiGravity", menuName = "Properties/AntiGravity Property")]
	public class AntiGravity : Property
	{
		public const float GravityMultiplier = 0.3f;

		public override void ApplyToNPC(NPC npc)
		{
		}

		public override void ApplyToPlayer(Player player)
		{
		}

		public override void ClearFromNPC(NPC npc)
		{
		}

		public override void ClearFromPlayer(Player player)
		{
		}
	}
}
