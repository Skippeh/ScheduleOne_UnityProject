namespace ScheduleOne.Properties
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Lethal", menuName = "Properties/Lethal Property")]
	public class Lethal : global::ScheduleOne.Properties.Property
	{
		public const float HEALTH_DRAIN_PLAYER = 15f;

		public const float HEALTH_DRAIN_NPC = 15f;

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
