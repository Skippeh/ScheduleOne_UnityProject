namespace ScheduleOne.Properties
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Sneaky", menuName = "Properties/Sneaky Property")]
	public class Sneaky : global::ScheduleOne.Properties.Property
	{
		public const float SPEED_MULTIPLIER = 0.85f;

		public const float FOOTSTEP_VOL_MULTIPLIER = 0.4f;

		private global::ScheduleOne.Vision.VisibilityAttribute visibilityAttribute;

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
