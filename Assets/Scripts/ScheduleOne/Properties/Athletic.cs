namespace ScheduleOne.Properties
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Athletic", menuName = "Properties/Athletic Property")]
	public class Athletic : global::ScheduleOne.Properties.Property
	{
		public const float SPEED_MULTIPLIER = 1.3f;

		public const float NPC_SPEED_MULTIPLIER = 1.8f;

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
