namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Shrinking", menuName = "Properties/Shrinking Property")]
	public class Shrinking : global::ScheduleOne.Effects.Effect
	{
		public const float Scale = 0.8f;

		public const float LerpTime = 1f;

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
