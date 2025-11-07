namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Seizure", menuName = "Properties/Seizure Property")]
	public class Seizure : global::ScheduleOne.Effects.Effect
	{
		public const float CAMERA_JITTER_INTENSITY = 1f;

		public const float DURATION_NPC = 60f;

		public const float DURATION_PLAYER = 30f;

		public override void ApplyToNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public override void ApplyToPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public override void ClearFromNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public override void ClearFromPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}
	}
}
