namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Sedating", menuName = "Properties/Sedating Property")]
	public class Sedating : global::ScheduleOne.Effects.Effect
	{
		public const float WorkSpeedMultiplier = 0.8f;

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
