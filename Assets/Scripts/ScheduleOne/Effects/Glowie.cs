namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Glowie", menuName = "Properties/Glowie Property")]
	public class Glowie : global::ScheduleOne.Effects.Effect
	{
		[global::UnityEngine.ColorUsage(true, true)]
		[global::UnityEngine.SerializeField]
		public global::UnityEngine.Color GlowColor;

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
