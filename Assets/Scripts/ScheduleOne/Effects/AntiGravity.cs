namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "AntiGravity", menuName = "Properties/AntiGravity Property")]
	public class AntiGravity : global::ScheduleOne.Effects.Effect
	{
		public const float GravityMultiplier = 0.3f;

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
