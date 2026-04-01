namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Energizing", menuName = "Properties/Energizing Property")]
	public class Energizing : global::ScheduleOne.Effects.Effect
	{
		public const float SPEED_MULTIPLIER = 1.15f;

		public const float WorkSpeedMultiplier = 1.15f;

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
