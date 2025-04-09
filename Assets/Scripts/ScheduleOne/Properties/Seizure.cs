using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	[CreateAssetMenu(fileName = "Seizure", menuName = "Properties/Seizure Property")]
	public class Seizure : Property
	{
		public const float CAMERA_JITTER_INTENSITY = 1f;

		public const float DURATION_NPC = 60f;

		public const float DURATION_PLAYER = 30f;

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
