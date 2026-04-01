namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Athletic", menuName = "Properties/Athletic Property")]
	public class Athletic : global::ScheduleOne.Effects.Effect
	{
		public const float SPEED_MULTIPLIER = 1.3f;

		public const float NPC_SPEED_MULTIPLIER = 1.8f;

		public const float WorkSpeedMultiplier = 1.05f;

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

		protected override void ApplyToEmployee(global::ScheduleOne.Employees.Employee employee)
		{
		}

		protected override void ClearFromEmployee(global::ScheduleOne.Employees.Employee employee)
		{
		}
	}
}
