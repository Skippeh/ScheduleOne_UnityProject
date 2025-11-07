namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Toxic", menuName = "Properties/Toxic Property")]
	public class Toxic : global::ScheduleOne.Effects.Effect
	{
		[global::UnityEngine.ColorUsage(true, true)]
		[global::UnityEngine.SerializeField]
		public global::UnityEngine.Color TintColor;

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
